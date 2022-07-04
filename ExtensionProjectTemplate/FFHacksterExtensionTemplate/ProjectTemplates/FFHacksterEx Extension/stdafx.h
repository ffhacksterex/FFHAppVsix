// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently

#pragma once

#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers

#ifndef VC_EXTRALEAN
#define VC_EXTRALEAN            // Exclude rarely-used stuff from Windows headers
#endif

#include "targetver.h"

#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS      // some CString constructors will be explicit

#include <afx.h>
#include <afxwin.h>         // MFC core and standard components
#include <afxcmn.h>
#include <afxdlgs.h>
#include <afxdialogex.h>
#include <afxcontrolbars.h>

#include "shared_resids.h"
#include "resource_coredefs.h"
#include "resource_utils.h"
#include "resource_settings.h"
#include "resource_subeditors.h"
#include "resource_editors.h"

#include "logging_functions.h"

#include <ff1-utils-controls.h>
