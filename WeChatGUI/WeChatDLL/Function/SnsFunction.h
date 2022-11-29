#pragma once
#include "../WeChat/SnsObj.h"

enum WeChatVersion;
class SnsModule
{
public:
	static SnsModule& Instance();
	bool InitSnsModule(WeChatVersion ver);
	std::vector<MyTimeLineResp> SyncSns();
private:
	void* SnsTimeLineMgr_Instance();
private:
	WeChatVersion WeChatVer;
};