#include "H5Web.h"
#include "../WeChatDLL.h"
#include "../WeChat/common.h"
#include "../InlineHook/InlineHook.h"
#include "../public/Strings.h"
#include "../public/Public.h"
#include <map>
#include <AnyCall/AnyCall.h>

InlineHook gHook_H5ExtTransferResponse;

std::unordered_map<std::string, std::string> gH5ExtTransferMap;
std::mutex gH5ExtTransferMutex;

void* H5AuthMgr_Instance()
{
	return AnyCall::invokeStdcall<void*>((void*)(WeChatDLL::Instance().getWinMoudule() + 0x9CA710));
}


std::string DoH5Transfer(std::string& cmdIndex, std::string& url, const std::string& api, std::string& reqJson, unsigned int cgi_cmdid, const std::string& scope, unsigned int is_security_check)
{
	void* gH5AuthMgr = H5AuthMgr_Instance();

	struct TransferReq
	{
		mmStringX index;
		mmStringX url;
		mmStringX api;
		mmStringX req_json;
		mmStringX scope;
		unsigned int is_security_check;
		unsigned int cgi_cmdid;
		unsigned int field_6C;
		unsigned int field_70;
		unsigned int field_74;
		unsigned int field_78;
		unsigned int field_7C;
		mmStringX req_time;
	};
	TransferReq reqData;
	reqData.index.assignUTF8(cmdIndex.c_str());
	reqData.url.assignUTF8(url.c_str());
	reqData.api.assignUTF8(api.c_str());
	reqData.req_json.assignUTF8(reqJson.c_str());
	reqData.scope.assignUTF8(scope.c_str());
	reqData.is_security_check = is_security_check;
	reqData.cgi_cmdid = cgi_cmdid;
	reqData.field_6C = 0x0;
	reqData.field_70 = 0x0;
	reqData.field_74 = 0x0;
	reqData.field_78 = 0x0;
	reqData.field_7C = 0x0;

	//添加任务
	{
		std::lock_guard<std::mutex> lock(gH5ExtTransferMutex);
		gH5ExtTransferMap[cmdIndex] = "";
	}

	std::string retJson;

	//H5AuthMgr::DoH5Transfer
	if (AnyCall::invokeThiscall<bool>(gH5AuthMgr, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xAE5080),&reqData)){
		std::this_thread::sleep_for(std::chrono::seconds(5));
	}

	//取回数据
	{
		std::lock_guard<std::mutex> lock(gH5ExtTransferMutex);
		retJson = gH5ExtTransferMap[cmdIndex];
		gH5ExtTransferMap.erase(cmdIndex);
	}
	return retJson;
}

//如何找到该函数,NetSceneH5ExtTransfer::onGYNetEnd
void __stdcall MyNetSceneH5ExtTransferOnGYNetEnd(HookContext* hookContext)
{
	char* NetSceneH5ExtTransfer = (char*)hookContext->ECX;
	char* H5ExtTransferRequest = *(char**)(NetSceneH5ExtTransfer + 0x200);
	if (!H5ExtTransferRequest) {
		return;
	}
	H5ExtTransferRequest = *(char**)(H5ExtTransferRequest + 0x8);
	char* JsApiResponse = *(char**)(NetSceneH5ExtTransfer + 0x204);
	JsApiResponse = *(char**)(JsApiResponse + 0x8);

	std::string strApi = ReadStdString(*(char***)(H5ExtTransferRequest + 0x4));
	std::string reqJson = ReadStdString(*(char***)(H5ExtTransferRequest + 0x8));
	unsigned int cgiCmdid = *(unsigned int*)(H5ExtTransferRequest + 0xC);

	std::string respJson = ReadStdString(*(char***)(JsApiResponse + 0x8));
	std::string cmdIndex = UnicodeToUtf8(copyMMString((mmString*)(NetSceneH5ExtTransfer + 0x218)).c_str());

	{
		std::lock_guard<std::mutex> lock(gH5ExtTransferMutex);
		std::unordered_map<std::string, std::string>::iterator it = gH5ExtTransferMap.find(cmdIndex);
		if (it != gH5ExtTransferMap.end()) {
			gH5ExtTransferMap[cmdIndex] = respJson;
		}
	}
}

void PLUGIN_H5Web()
{
	DWORD hWeChatWinDLL = WeChatDLL::Instance().getWinMoudule();
	gHook_H5ExtTransferResponse.AddHook((LPVOID)(hWeChatWinDLL + 0xC6BC30), MyNetSceneH5ExtTransferOnGYNetEnd);
}