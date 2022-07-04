#pragma once

#ifdef $projectsymbol$_EXPORTS
#define $projectsymbol$_API __declspec(dllexport)
#else
#define $projectsymbol$_API __declspec(dllimport)
#endif

#include "EditorInterop.h"

extern "C"
{
	$projectsymbol$_API char* Invoke(const EditorInterop * ei);
}
