#pragma once
#include <Enemy.h>

class CCustomEnemy : public CEnemy
{
public:
	CCustomEnemy(CWnd* parent = nullptr);

protected:
	virtual void DoDataExchange(CDataExchange* pDX);
	virtual BOOL OnInitDialog();

	CClearButton m_testbtn;

	DECLARE_MESSAGE_MAP()
	afx_msg void OnTestButton();
public:
	virtual INT_PTR DoModal();
};
