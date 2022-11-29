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
	//等待微信登录
	std::wstring WaitUtilLogin();
	//保存登录二维码
	void setLoginQRCode(char* pImgBuf, int imgLen);
	//获取登录二维码
	bool getLoginQRCode(std::vector<unsigned char>& outQRCode);

	//获取当前wxid
	std::wstring getCurrentUserWxid();
public:
	std::wstring currentUserWxid;
	std::vector<unsigned char> currentQRCode;
	std::mutex qrcodeMutex;
private:
	WeChatVersion WeChatVer;
};