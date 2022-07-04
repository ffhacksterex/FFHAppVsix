// SampleEditor.cpp : implementation file
//

#include "stdafx.h"
#include "$projectname$.h"
#include "SampleEditor.h"
#include "afxdialogex.h"


// CSampleEditor dialog

IMPLEMENT_DYNAMIC(CSampleEditor, CEditorWithBackground)

CSampleEditor::CSampleEditor(CWnd* pParent /*=nullptr*/)
	: CEditorWithBackground(IDD_SAMPLEEDITOR, pParent)
{
}

CSampleEditor::~CSampleEditor()
{
}

void CSampleEditor::LoadRom()
{
}

void CSampleEditor::SaveRom()
{
}

void CSampleEditor::LoadValues()
{
}

void CSampleEditor::StoreValues()
{
}

void CSampleEditor::DoDataExchange(CDataExchange* pDX)
{
	CEditorWithBackground::DoDataExchange(pDX);
	DDX_Control(pDX, IDOK, m_okbutton);
	DDX_Control(pDX, IDCANCEL, m_cancelbutton);
}

BOOL CSampleEditor::OnInitDialog()
{
	CEditorWithBackground::OnInitDialog();
	m_banner.Set(this, COLOR_BLACK, COLOR_ORANGE, "Sample Editor");
	return FALSE;
}


BEGIN_MESSAGE_MAP(CSampleEditor, CEditorWithBackground)
END_MESSAGE_MAP()


// CSampleEditor message handlers
