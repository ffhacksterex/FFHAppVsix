#pragma once
#include <Enemy.h>

class CCustomEnemy : public CEnemy
{
public:
	CCustomEnemy(CWnd* parent = nullptr);

// Public MFC overrides 
	virtual INT_PTR DoModal();

protected:
// Dialog Data
	CClearButton m_testbtn;

// MFC overrides and message handlers
	virtual void DoDataExchange(CDataExchange* pDX);
	virtual BOOL OnInitDialog();

	DECLARE_MESSAGE_MAP()
	afx_msg void OnTestButton();
};
