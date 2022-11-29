#include "LogFunction.h"
#include <string>
#include "spdlog/spdlog.h"
#include "spdlog/sinks/basic_file_sink.h"
#include "../MinHook/MinHook.h"
#include "../WeChatDLL.h"

typedef struct {
	int logLevel;
	//类名
	char* className;
	char* sourceName;
	//函数名
	char* funcName;
	int logID;
}MMLogInfo;

typedef int(_cdecl* funcLogMessage)(MMLogInfo* pLogInfo, char* logMessage);

funcLogMessage gFuncLogMessage = NULL;

auto logger = spdlog::basic_logger_mt("log", "logs/basic-log.txt");

int _cdecl MyLogMessage(MMLogInfo* pLogInfo, char* logMessage)
{
	std::string className = pLogInfo->className;
	std::string funcName = pLogInfo->funcName;
	std::string funcCall = className + "::" + funcName;
	logger->info(funcCall + logMessage);
	//OutputDebugStringA(logMessage);
	return gFuncLogMessage(pLogInfo,logMessage);
}

bool HOOK_日志打印()
{
	DWORD hWeChatWinDLL = WeChatDLL::Instance().getWinMoudule();
	MH_CreateHook((LPVOID)(hWeChatWinDLL + 0x1736A50), MyLogMessage, (LPVOID*)&gFuncLogMessage);
	MH_EnableHook((LPVOID)(hWeChatWinDLL + 0x1736A50));
	return true;
}