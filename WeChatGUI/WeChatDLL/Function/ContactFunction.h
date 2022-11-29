#pragma once
#include <string>
#include "../WeChat/Contact.h"
#include <vector>

enum WeChatVersion;
class ContactModule
{
public:
	static ContactModule& Instance();
	void InitContactModule(WeChatVersion ver);
	MyContact GetContactInfoDynamic(std::wstring userName);
	std::vector<MyContact> GetContactList();
private:
	void* ContactMgr_Instance();
private:
	WeChatVersion WeChatVer;
};