#include "AccountFunction.h"
#include "../WeChatDLL.h"
#include "../InlineHook/InlineHook.h"
#include "../public/Strings.h"
#include "../public/Public.h"
#include "../proto/UserInfo.pb.h"
#include "MsgMonitor.h"

InlineHook gHook_GetProfileResponse;
InlineHook gHook_LoginWnd_eventProc;

AccountFunction& AccountFunction::Instance()
{
	static AccountFunction gAccountFunction;
	return gAccountFunction;
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
			MsgUploadInfo uploadMsg;
			uploadMsg.msg["msg_type"] = WX_LoginQRCodeMsg;
			uploadMsg.msg["qrcode"] = base64_encode((unsigned char*)pImgBuf,imgLen);
			MsgMonitor::Instance().AddMsg(uploadMsg);
		}
	}
	//二维码过期了
	else if (eventID == 0x302) {
		
	}
}

//如何找到该函数,micromsg::GetProfileResponse
void __stdcall MyGetProfileResponse(HookContext* hookContext)
{
	char* pResponseBuf = *(char**)hookContext->ESP;
	int respLen = *(int*)(hookContext->ESP + 4);
	GetProfileResponse getProfileResp;
	if (!getProfileResp.ParseFromArray(pResponseBuf, respLen)) {
		WeChatDLL::Instance().MsgRecvLogger()->error(BinToHex((unsigned char*)pResponseBuf, respLen));
		return;
	}
	MsgUploadInfo uploadMsg;
	uploadMsg.msg["msg_type"] = WX_SyncUserProfile;
	uploadMsg.msg["wxid"] = getProfileResp.userinfo().username().string();
	uploadMsg.msg["nickname"] = getProfileResp.userinfo().nickname().string();
	uploadMsg.msg["uin"] = getProfileResp.userinfo().binduin();
	std::string email = getProfileResp.userinfo().bindemail().string();
	if (!email.empty()) {
		uploadMsg.msg["email"] = email;
	}
	uploadMsg.msg["mobile"] = getProfileResp.userinfo().bindmobile().string();
	uploadMsg.msg["province"] = getProfileResp.userinfo().province();
	uploadMsg.msg["city"] = getProfileResp.userinfo().city();
	uploadMsg.msg["signature"] = getProfileResp.userinfo().signature();
	uploadMsg.msg["alias"] = getProfileResp.userinfo().alias();
	MsgMonitor::Instance().AddMsg(uploadMsg);

	AccountFunction::Instance().currentUserWxid = Utf8ToUnicode(getProfileResp.userinfo().username().string().c_str());
}

std::wstring AccountFunction::getCurrentUserWxid()
{
	return this->currentUserWxid;
}

bool AccountFunction::InitAccountModule(WeChatVersion v)
{
	WeChatVer = v;
	DWORD hWeChatWinDLL = WeChatDLL::Instance().getWinMoudule();

	switch (WeChatVer) {
	case WeChat_3_7_6_44:
		return true;
	case WeChat_3_8_0_33:
		gHook_GetProfileResponse.AddHook((LPVOID)(hWeChatWinDLL + 0xC4BA79), MyGetProfileResponse);
		gHook_LoginWnd_eventProc.AddHook((LPVOID)(hWeChatWinDLL + 0x997B60),MyLoginWndEventProc);
		return true;
	default:
		break;
	}
	return false;
}

