#include "GetA8Key.h"
#include "../WeChatDLL.h"
#include "../WeChat/common.h"
#include "../InlineHook/InlineHook.h"
#include "../public/Strings.h"
#include <map>
#include <AnyCall/AnyCall.h>
#include "../proto/Common.pb.h"
#include "../proto/A8Key.pb.h"

InlineHook gHook_A8KeyResp;
std::map<std::string, std::string> gMapA8Key;
std::mutex gA8KeyMutex;

void* SceneCenter_Instance()
{
	return AnyCall::invokeStdcall<void*>((void*)(WeChatDLL::Instance().getWinMoudule() + 0x6C89E0));
}

std::string GetA8Key(std::string reqUrl)
{
	char* pNetSceneGetA8Key = new char[0x238];
	mmStringX mmReqUrl;
	mmStringX extraData;
	mmReqUrl.assignUTF8(reqUrl.c_str());
	AnyCall::invokeThiscall<void*>(pNetSceneGetA8Key, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x556CE0), mmReqUrl,
		0x0, 0x0, 0x4, 0x2, extraData, 0x0);
	pNetSceneGetA8Key[529] = 0x0;
	pNetSceneGetA8Key[528] = 0x0;

	struct RefNetSceneGetA8Key
	{
		DWORD* pNetSceneGetA8Key;
		DWORD* pRefData;
	};
	RefNetSceneGetA8Key refNetSceneGetA8Key;
	AnyCall::invokeThiscall<void*>(&refNetSceneGetA8Key, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x8B9124), pNetSceneGetA8Key);
	if (refNetSceneGetA8Key.pRefData) {
		_InterlockedIncrement(refNetSceneGetA8Key.pRefData + 1);
	}
	void* pSceneCenter = SceneCenter_Instance();

	//添加任务
	{
		std::lock_guard<std::mutex> lock(gA8KeyMutex);
		gMapA8Key[reqUrl] = "";
	}

	//SceneCenter::doScene
	AnyCall::invokeThiscall<void*>(pSceneCenter, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x5120E0), refNetSceneGetA8Key.pNetSceneGetA8Key,
		refNetSceneGetA8Key.pRefData);

	//释放智能指针
	AnyCall::invokeThiscall<void*>(&refNetSceneGetA8Key, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x675680));

	std::this_thread::sleep_for(std::chrono::seconds(5));

	//取出结果
	std::string retUrl;
	{
		std::lock_guard<std::mutex> lock(gA8KeyMutex);
		retUrl = gMapA8Key[reqUrl];
		gMapA8Key.erase(reqUrl);
	}
	return retUrl;
}

//如何找到该函数,GetA8KeyResp
void __stdcall MyGetA8KeyResp(HookContext* hookContext)
{
	char* pResponseBuf = *(char**)hookContext->ESP;
	int respLen = *(int*)(hookContext->ESP + 4);

	GetA8KeyResp a8KeyResp;
	if (!a8KeyResp.ParseFromArray(pResponseBuf, respLen)) {
		return;
	}
	std::string fullUrl = a8KeyResp.fullurl();
	std::string shareUrl = a8KeyResp.shareurl();
	{
		std::lock_guard<std::mutex> lock(gA8KeyMutex);
		std::map<std::string, std::string>::iterator it = gMapA8Key.find(shareUrl);
		if (it != gMapA8Key.end()) {
			gMapA8Key[shareUrl] = fullUrl;
		}
	}
}

void PLUGIN_GetA8Key()
{
	DWORD hWeChatWinDLL = WeChatDLL::Instance().getWinMoudule();
	gHook_A8KeyResp.AddHook((LPVOID)(hWeChatWinDLL + 0xC325C9), MyGetA8KeyResp);
}