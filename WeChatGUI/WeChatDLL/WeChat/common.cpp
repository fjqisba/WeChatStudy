#include "common.h"
#include "../public/Strings.h"
#include "../WeChatDLL.h"
#include <AnyCall/AnyCall.h>

std::wstring copyMMString(mmString* mmStr)
{
	std::wstring ret;
	if (mmStr->pUnicode && *mmStr->pUnicode) {
		ret.assign(mmStr->pUnicode,mmStr->Mysize);
	}
	return ret;
}

mmString::mmString()
{
	pUnicode = 0x0;
	Mysize = 0x0;
	Myres = 0x0;
	pUTF8 = 0x0;
	uLen = 0x0;
}


//特征提示:StartWechat函数，第一个函数
void mmString::assign(const wchar_t* src, int len)
{
	switch (WeChatDLL::Instance().getWechatVersion())
	{
	case WeChat_3_7_6_44:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x8167B0), src, len);
		return;
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xDBBA10), src, len);
		return;
	}
	return;
}

void mmString::assignUTF8(const char* src)
{
	std::wstring wStr = Utf8ToUnicode(src);
	this->assign(wStr.c_str(), wStr.size());
}

//特征:StartWechat函数里面最后的函数

void mmString::free()
{
	switch (WeChatDLL::Instance().getWechatVersion()) {
	case WeChat_3_7_6_44:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x131D00));
		return;
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x651A90));
		return;
	}
}

mmStringX::mmStringX(const mmStringX& s)
{
	if (!s.Mysize) {
		return;
	}
	wchar_t* pBuf = new wchar_t[s.Mysize + 1];
	if (pBuf) {
		wmemcpy(pBuf, s.pUnicode, s.Mysize);
		pBuf[s.Mysize] = 0x0;
		this->pUnicode = pBuf;
		this->Mysize = s.Mysize;
		this->Myres = s.Mysize;
	}
}

mmStringX::mmStringX()
{

}

mmStringX::~mmStringX()
{
	free();
}

