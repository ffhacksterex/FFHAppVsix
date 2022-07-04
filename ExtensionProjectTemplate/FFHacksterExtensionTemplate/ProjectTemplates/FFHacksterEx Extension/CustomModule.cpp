#include "stdafx.h"
#include "CustomModule.h"
#include <io_functions.h>
#include <type_support.h>

#include <Editors2.h>
#include <FFHacksterProject.h>
#include <IniOverrider.h>
#include "CustomEnemy.h"
#include "SampleEditor.h"

using namespace Editors2;
using namespace Ini;
using namespace Io;
using namespace Types;

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

#define SAMPLEEDITOR "sampleedit"

CCustomModule::CCustomModule()
{
}

CCustomModule::~CCustomModule()
{
}

Editors2::sEditorInfoVector CCustomModule::GetEditorInfos()
{
	const CString modulepath = Io::GetCurrentModulePath();
	const sEditorInfoVector infos{
		//TODO - modify this list to change the available editors on the FFHacksterEx main window
		{ true, SAMPLEEDITOR, "Sample", modulepath, "Example of adding a new editor." },
		{ true, ENEMIESEDIT, "Custom Enemies", modulepath, "Customized enemy editor that doesn't do anything special." },
	};
	return infos;
}

std::pair<Editors2::EditErrCode, CString> CCustomModule::OverrideValues(CString projectini)
{
	CString overrider = "$inigroupname$";

	auto valpath = CFFHacksterProject::GetIniFilePath(projectini, FFHFILE_ValuesPath);
	if (valpath.IsEmpty()) {
		return{ EditErrCode::FileMissing, "Can't find the '" + overrider + " 'project's config values file." };
	}

	try {
		auto hexupper = m_appsettings.SaveHexAsUppercase;
		const auto hexval = [hexupper](int value, int digits) -> CString {
			return hex_upper(hex(value, digits * 2), hexupper);
		};

		// Overrider can both add and override values.
		CString group = "Override Samples";
		IniOverrider ini(valpath, overrider);
		//TODO - add or override entries in the Values list
		ini.Override("TESTADDR", "addr", "$CD34", "Samples", "Override an existing value");
		ini.Override("TESTINT8", "int8", "123", group, "Override an existing value and change its group");
		ini.Override("TEST_ADD_OFFSET", "bword", hexval(0x3456F, 5), group, "An example of adding a value that isn't present by default");
	}
	catch (std::exception & ex) {
		return{ EditErrCode::ExceptionCaught, "Can't write the config values for " + overrider + " (" + CString(ex.what()) + ")" };
	}
	catch (...) {
		return{ EditErrCode::ExceptionCaught, "Can't write the config values for " + overrider };
	}

	return EDITCMD_IGNORED;
}

std::pair<Editors2::EditErrCode, CString> CCustomModule::HandleInit(const EditorInterop& ei)
{
	//TODO - do custom per-module initialization here
	return EDITCMD_IGNORED;
}

std::pair<Editors2::EditErrCode, CString> CCustomModule::HandleCommand(CFFHacksterProject & proj, const EditorInterop & ei)
{
	// Command handler implemented as a lambda expression
	const auto InvokeSampleEditor = [](CFFHacksterProject& proj) {
		CSampleEditor dlg;
		dlg.Project = &proj;
		dlg.DoModal();
		return IDOK;
	};

	// In this case, use a map to handle commands and subcommands
	std::pair<EditErrCode, CString> ec = EDITCMD_IGNORED;
	CString command = ei.command;
	CString name = ei.name;

	QueryHandlerMap querymap{
		// Define handlers as either member functions/methods or lambda expressions.
		//TODO - add additional handler mappings here
		{ { SAMPLEEDITOR,INVOKE_EDIT }, [&,this]() { return InvokeSampleEditor(proj); } },
		{ { ENEMIESEDIT, INVOKE_EDIT }, [&,this]() { return InvokeEnemiesEditor(proj); } }
	};

	auto iter = querymap.find({ name, command });
	if (iter != cend(querymap)) {
		auto func = iter->second;
		auto result = func();
		if (result != IDOK && result != IDCANCEL)
			ec = { EditErrCode::Failure, "the dialog edit aborted without an OK or Cancel." };
	}

	return ec;
}

// Command handler implemented as a member function/method

INT_PTR CCustomModule::InvokeEnemiesEditor(CFFHacksterProject& proj)
{
	CCustomEnemy dlg;
	dlg.Project = &proj;
	auto retval = dlg.DoModal();
	return retval;
}