#include "stdafx.h"
#include "CustomEnemy.h"
#include <FFBaseApp.h>
#include <ui_helpers.h>

#define IDC_TESTBUTTON 4999

CCustomEnemy::CCustomEnemy(CWnd* parent)
{
}

BEGIN_MESSAGE_MAP(CCustomEnemy, CEnemy)
	ON_BN_CLICKED(IDC_TESTBUTTON, OnTestButton)
END_MESSAGE_MAP()

INT_PTR CCustomEnemy::DoModal()
{
	// Always use mappings for this modal; allows finding controls by name (see OnInitDialog)
	PreloadControlMappings = true;
	return CEnemy::DoModal();
}

void CCustomEnemy::DoDataExchange(CDataExchange* pDX)
{
	CEnemy::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_TESTBUTTON, m_testbtn);
}

BOOL CCustomEnemy::OnInitDialog()
{
	m_testbtn.CreateButton(IDC_TESTBUTTON, "Test", CRect(0, 0, 1, 1), this);

	auto retval = CEnemy::OnInitDialog();

	// Rename the banner text
	m_banner.Text = "Custom Enemies";

	// Example of finding controls by name (string)
	// Find the AI group button by name, then rename it to "Attack Pattern".
	//N.B. - Requires setting PreloadControlMappings member to true before calling DoModal.
	auto aistatic = GetControlByName("IDC_ENEMY_GROUP_AI");
	if (aistatic != nullptr) {
		aistatic->SetWindowText("Attack Pattern");
	}

	// Example of finding controls by ID (integer)
	// Find the "Edit Graphic" button by ID, then rename it "EDIT PIC" and move it up.
	auto btngfx = GetDlgItem(IDC_EDITPIC);
	if (btngfx != nullptr) {
		btngfx->SetWindowText("EDIT PIC");

		auto rcorig = Ui::GetControlRect(btngfx);
		Ui::MoveControlBy(btngfx, 0, -66);
		m_testbtn.MoveWindow(&rcorig);
	}

	return retval;
}

void CCustomEnemy::OnTestButton()
{
	AfxMessageBox("Test button pushed.");
}