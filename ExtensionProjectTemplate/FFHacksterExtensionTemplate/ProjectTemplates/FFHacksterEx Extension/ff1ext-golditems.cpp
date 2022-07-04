// $projectname$.cpp : Defines the initialization routines for the DLL.
//

#include "stdafx.h"
#include "$projectname$.h"
#include "CustomModule.h"
#include <FFBaseApp.h>
#include "$projectname$-resource.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


CCustomModule theApp; // The one and only application object


extern "C"
{

	$projectsymbol$_API char* Invoke(const EditorInterop * ei)
	{
		CString response = theApp.Invoke(ei);
		if (response.IsEmpty())
			return nullptr;
		return Editors2::AllocReturnValue(ei->allocator, response);
	}

}