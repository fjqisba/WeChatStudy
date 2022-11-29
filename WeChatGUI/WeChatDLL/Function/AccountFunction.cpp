#include "AccountFunction.h"
#include "../WeChatDLL.h"
#include "../InlineHook/InlineHook.h"
#include "../public/Strings.h"

InlineHook gHook_SetCurrentUserWxid;
InlineHook gHook_AccountSvrLogin;
InlineHook gHook_AccountSvrLogout;
InlineHook gHook_LoginWnd_eventProc;
HANDLE gLoginEvent;

AccountFunction& AccountFunction::Instance()
{
	static AccountFunction gAccountFunction;
	return gAccountFunction;
}

void __stdcall MySetCurrentUserWxid(HookContext* hookContext)
{
	//gHook_SetCurrentUserWxid.AddHook((LPVOID)(hWeChatWinDLL + 0x7232CD), MySetCurrentUserWxid);
	char* pWxid = (char*)(hookContext->EAX);
	if (pWxid) {
		AccountFunction::Instance().currentUserWxid = AnsiToUnicode(pWxid);
	}
}

//hook的是函数头
void __stdcall AccountService_login(HookContext* hookContext)
{
	SetEvent(gLoginEvent);
	//第一个参数
	char* pWxid = (char*)*(DWORD*)(hookContext->ESP + 0x4);
	AccountFunction::Instance().currentUserWxid = AnsiToUnicode(pWxid);
}

void __stdcall AccountService_logout(HookContext* hookContext)
{
	ResetEvent(gLoginEvent);
}


std::wstring AccountFunction::WaitUtilLogin()
{
	WaitForSingleObject(gLoginEvent, INFINITE);
	return AccountFunction::currentUserWxid;
}

std::wstring AccountFunction::getCurrentUserWxid()
{
	return this->currentUserWxid;
}

bool AccountFunction::getLoginQRCode(std::vector<unsigned char>& outQRCode)
{
	std::lock_guard<std::mutex> lock(this->qrcodeMutex);
	if (!this->currentQRCode.size()) {
		return false;
	}
	outQRCode = this->currentQRCode;
	return true;
}

void AccountFunction::setLoginQRCode(char* pImgBuf, int imgLen)
{
	std::lock_guard<std::mutex> lock(this->qrcodeMutex);
	this->currentQRCode.resize(imgLen, 0x0);
	memcpy(&this->currentQRCode[0], pImgBuf, imgLen);
}

//如何找到该函数,LoginWnd::eventProc
void __stdcall MyLoginWndEventProc(HookContext* hookContext)
{
	//消息类型
	DWORD eventID = *(DWORD*)(hookContext->ESP + 0x4);
	//消息参数
	char* eventParam = *(char**)(hookContext->ESP + 0x10);

	AccountFunction& accountInstance = AccountFunction::Instance();

	//二维码获取
	if (eventID == 0x300) {
		char* pImgBuf = *(char**)(eventParam + 0x30);
		int imgLen = *(int*)(eventParam + 0x34);
		if (imgLen) {
			accountInstance.setLoginQRCode(pImgBuf, imgLen);
		}
	}
	//二维码过期了
	else if (eventID == 0x302) {

	}
}

bool AccountFunction::InitAccountModule(WeChatVersion v)
{
	std::string loginEvent = "WeChatLogin_" + std::to_string(GetCurrentProcessId());
	gLoginEvent = CreateEventA(NULL, true, false, loginEvent.c_str());

	WeChatVer = v;
	DWORD hWeChatWinDLL = WeChatDLL::Instance().getWinMoudule();

	switch (WeChatVer) {
	case WeChat_3_7_6_44:
		gHook_AccountSvrLogin.AddHook((LPVOID)(hWeChatWinDLL + 0x723270), AccountService_login);
		gHook_AccountSvrLogout.AddHook((LPVOID)(hWeChatWinDLL + 0x7240F0), AccountService_logout);
		return true;
	case WeChat_3_8_0_33:
		gHook_AccountSvrLogin.AddHook((LPVOID)(hWeChatWinDLL + 0xCC7BC0), AccountService_login);
		gHook_AccountSvrLogout.AddHook((LPVOID)(hWeChatWinDLL + 0xCC8A50), AccountService_logout);

		gHook_LoginWnd_eventProc.AddHook((LPVOID)(hWeChatWinDLL + 0x997B60),MyLoginWndEventProc);
		return true;
	default:
		break;
	}
	return false;
}

