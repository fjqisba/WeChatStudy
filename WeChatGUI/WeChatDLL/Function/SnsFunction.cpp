#include "SnsFunction.h"
#include <condition_variable>
#include "../WeChatDLL.h"
#include <AnyCall/AnyCall.h>
#include "../InlineHook/InlineHook.h"

InlineHook gHook_OnSnsTimeLineSceneFinish;

//一组锁
std::condition_variable gCv;
std::mutex gMutex;
std::vector<MyTimeLineResp> gTimeLineRespList;

SnsModule& SnsModule::Instance()
{
	static SnsModule gSnsModule;
	return gSnsModule;
}

//如何找到该函数,SnsTimeLineMgr::OnSnsTimeLineSceneFinish
void __stdcall MyOnSnsTimeLineSceneFinish(HookContext* hookContext)
{
	char* pData = (char*)*(DWORD*)(hookContext->ESP + 4);
	char* pVectorStart = (char*)*(DWORD*)(pData + 0x20);
	char* pVecotrEnd = (char*)*(DWORD*)(pData + 0x24);
	unsigned int msgCount = (pVecotrEnd - pVectorStart) / 0xB48;
	if (msgCount == 0) {
		gCv.notify_one();
		return;
	}
	
	std::unique_lock<std::mutex> lck(gMutex);
	gTimeLineRespList.clear();
	for (unsigned int n = 0; n < msgCount; ++n, pVectorStart = pVectorStart + 0xB48) {
		TimelineResp* pResp = (TimelineResp*)pVectorStart;
		MyTimeLineResp tmpResp = CopyTimeLineResp(pResp);
		gTimeLineRespList.push_back(tmpResp);
	}
	gCv.notify_one();
}


bool SnsModule::InitSnsModule(WeChatVersion ver)
{
	this->WeChatVer = ver;
	DWORD hWeChatWinDLL = WeChatDLL::Instance().getWinMoudule();

	switch (ver) {
	case WeChat_3_7_6_44:
		gHook_OnSnsTimeLineSceneFinish.AddHook((LPVOID)(hWeChatWinDLL + 0xCF05F0), MyOnSnsTimeLineSceneFinish);
		return true;
	case WeChat_3_8_0_33:
		gHook_OnSnsTimeLineSceneFinish.AddHook((LPVOID)(hWeChatWinDLL + 0x12DC220), MyOnSnsTimeLineSceneFinish);
		return true;
	}
	return false;
}

std::vector<MyTimeLineResp> SnsModule::SyncSns()
{
	std::vector<MyTimeLineResp> retList;

	//判断登录窗口是否存在,如何找到该基址,MainWnd has been launched
	DWORD* hMainWnd = NULL;
	switch (this->WeChatVer) {
	case WeChat_3_7_6_44:
		hMainWnd = (DWORD*)(WeChatDLL::Instance().getWinMoudule() + 0x2535F3C);
		break;
	case WeChat_3_8_0_33:
		hMainWnd = (DWORD*)(WeChatDLL::Instance().getWinMoudule() + 0x2BED8F4);
		break;
	}
	if (!hMainWnd){
		return retList;
	}

	//TryGetFirstPageScene
	char* pSnsTimeLineMgr = (char*)SnsTimeLineMgr_Instance();
	char bFlag = 1;

	switch (this->WeChatVer) {
	case WeChat_3_7_6_44:
		AnyCall::invokeThiscall<void>(pSnsTimeLineMgr, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xCF3CC0), bFlag);
		break;
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>(pSnsTimeLineMgr, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x12DF8F0), bFlag);
		break;
	}

	//等待消息返回
	std::unique_lock<std::mutex> lck(gMutex);
	gCv.wait(lck);
	return gTimeLineRespList;
}


//如何找到该函数,TryGetFirstPageScene
void* SnsModule::SnsTimeLineMgr_Instance()
{
	switch (this->WeChatVer) {
	case WeChat_3_7_6_44:
		return AnyCall::invokeStdcall<void*>((void*)(WeChatDLL::Instance().getWinMoudule() + 0xC82370));
	case WeChat_3_8_0_33:
		return AnyCall::invokeStdcall<void*>((void*)(WeChatDLL::Instance().getWinMoudule() + 0x126E3E0));
	}
	return NULL;
}

