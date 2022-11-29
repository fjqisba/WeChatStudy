#pragma once
#include <windows.h>
#include "spdlog/sinks/basic_file_sink.h"

enum WeChatVersion
{
	WeChat_NotSupport = 0x0,
	WeChat_3_7_6_44 = 0x37644,
	WeChat_3_8_0_33 = 0x38033,
};

//OTM0ODIxNzMw
class WeChatDLL
{
public:
	WeChatDLL();
	~WeChatDLL();
public:
	static WeChatDLL& Instance();
	std::shared_ptr<spdlog::logger>& MsgRecvLogger();
	std::shared_ptr<spdlog::logger>& WeChatLogger();
	DWORD getWinMoudule();
	WeChatVersion getWechatVersion();
	void FreeDLL();
	void InitDLL();
	bool initVersion(std::string& ver);
private:
	DWORD m_hWeChatWinDLL;
	WeChatVersion m_WechatVer;
	std::shared_ptr<spdlog::logger> m_MsgRecvLoger;
	std::shared_ptr<spdlog::logger> m_WechatDLLLoger;
};