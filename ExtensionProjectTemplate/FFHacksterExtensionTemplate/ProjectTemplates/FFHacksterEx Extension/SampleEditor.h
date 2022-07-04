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

// Dialog Data
	enum { IDD = IDD_SAMPLEEDITOR };

protected:
	CClearButton m_okbutton;
	CClearButton m_cancelbutton;

	void LoadRom();
	virtual void SaveRom();
	void LoadValues();
	virtual void StoreValues();

	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual BOOL OnInitDialog();

	DECLARE_MESSAGE_MAP()
};
