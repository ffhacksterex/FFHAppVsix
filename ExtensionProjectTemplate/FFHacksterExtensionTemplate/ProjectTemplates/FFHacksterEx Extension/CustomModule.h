#pragma once

#include <FFHExtensionModule.h>

class CCustomModule : public CFFHExtensionModule
{
public:
	CCustomModule();
	virtual ~CCustomModule();

private:
	// Inherited via CFFHExtensionModule
	virtual Editors2::sEditorInfoVector GetEditorInfos() override;

	virtual std::pair<Editors2::EditErrCode, CString> OverrideValues(CString projectini);
	virtual std::pair<Editors2::EditErrCode, CString> HandleInit(const EditorInterop& ei);
	virtual std::pair<Editors2::EditErrCode, CString> HandleCommand(CFFHacksterProject & proj, const EditorInterop & ei);

	INT_PTR InvokeEnemiesEditor(CFFHacksterProject& proj);
};
