#include "WeChatDLL.h"
#include "public/WinApi.h"
#include "InlineHook/InlineHook.h"
#include "MinHook/MinHook.h"
#include "Function/LogFunction.h"
#include "Function/微信多开.h"
#include "Function/MsgMonitor.h"
#include "Function/ContactFunction.h"
#include "Function/AccountFunction.h"
#include "Function/SnsFunction.h"
#include "Function/LogFunction.h"
#include "Function/GetA8Key.h"
#include "Function/H5Web.h"
#include "微信偏移.h"
#include "ApiServer.h"
#include "WeChat/ChatMsg.h"

bool WeChatDLL::initVersion(std::string& dllVersion)
{
	if (dllVersion == "3.7.6.44") {
		m_WechatVer = WeChat_3_7_6_44;
		return true;
	}
	else if (dllVersion == "3.8.0.33") {
		m_WechatVer = WeChat_3_8_0_33;
		return true;
	}

	return false;
}

void WeChatDLL::InitDLL()
{
	m_hWeChatWinDLL = (DWORD)LoadLibraryA("WeChatWin.dll");
	std::string dllPath = getModulePath((HMODULE)m_hWeChatWinDLL);
	std::string dllVersion = getFileVersion(dllPath.c_str());

	if (dllVersion.empty()) {
		return;
	}
	if (!initVersion(dllVersion)) {
		return;
	}
	Patch_微信多开(m_WechatVer);
	ContactModule::Instance().InitContactModule(m_WechatVer);
	if (!AccountFunction::Instance().InitAccountModule(m_WechatVer)) {
		return;
	}
	if (!SnsModule::Instance().InitSnsModule(m_WechatVer)) {
		return;
	}
	if (!MsgMonitor::Instance().InitMsgMonitor(m_WechatVer)) {
		return;
	}
	int listenPort = atoi(GetCommandLineA());
	if (!listenPort) {
		listenPort = 5000;
	}

	//PLUGIN_GetA8Key();
	//PLUGIN_H5Web();

	//用std::thread貌似有兼容性问题?改用CreateThread
	CreateThread(NULL, 0, (LPTHREAD_START_ROUTINE)StartApiServer, (LPVOID)listenPort, 0,0);
}

WeChatDLL::WeChatDLL()
{
	MH_Initialize();

	m_MsgRecvLoger = spdlog::basic_logger_mt("MsgRecv", "logs/MsgRecv_" + std::to_string(GetCurrentProcessId()) + ".log");
	m_MsgRecvLoger->flush_on(spdlog::level::err);
	m_WechatDLLLoger = spdlog::basic_logger_mt("WeChatDLL", "logs/WeChatDLL_" + std::to_string(GetCurrentProcessId()) + ".log");
	m_WechatDLLLoger->flush_on(spdlog::level::err);
}

WeChatDLL::~WeChatDLL()
{
	MH_Uninitialize();
}

WeChatDLL& WeChatDLL::Instance()
{
	static WeChatDLL Wechat;
	return Wechat;
}

std::shared_ptr<spdlog::logger>& WeChatDLL::MsgRecvLogger()
{
	return this->m_MsgRecvLoger;
}

std::shared_ptr<spdlog::logger>& WeChatDLL::WeChatLogger()
{
	return this->m_WechatDLLLoger;
}

DWORD WeChatDLL::getWinMoudule()
{
	return m_hWeChatWinDLL;
}

WeChatVersion WeChatDLL::getWechatVersion()
{
	return m_WechatVer;
}

void WeChatDLL::FreeDLL()
{

}
