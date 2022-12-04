#pragma once
#include <string>
#include <mutex>
#include <vector>

enum WeChatVersion;
class AccountFunction
{
public:
	static AccountFunction& Instance();
	bool InitAccountModule(WeChatVersion ver);
	//获取当前wxid
	std::wstring getCurrentUserWxid();
public:
	std::wstring currentUserWxid;
	std::vector<unsigned char> currentQRCode;
	std::mutex qrcodeMutex;
private:
	WeChatVersion WeChatVer;
};