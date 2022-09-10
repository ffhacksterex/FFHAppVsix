#pragma once

#include <EditorWithBackground.h>
#include "$projectname$-resource.h"
#include <ClearButton.h>

// CSampleEditor dialog

class CSampleEditor : public CEditorWithBackground
{
	DECLARE_DYNAMIC(CSampleEditor)
public:
	CSampleEditor(CWnd* pParent = nullptr);   // standard constructor
	virtual ~CSampleEditor();

protected:
	virtual void LoadOffsets();
	virtual void LoadRom();
	virtual void SaveRom();
	virtual void LoadValues();
	virtual void StoreValues();

// Dialog Data
	enum { IDD = IDD_SAMPLEEDITOR };

	CClearButton m_okbutton;
	CClearButton m_cancelbutton;

// MFC overrides and message handlers
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual BOOL OnInitDialog();
	DECLARE_MESSAGE_MAP()
};
