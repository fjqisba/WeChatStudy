#include "ContactFunction.h"
#include <unordered_map>
#include "../InlineHook/InlineHook.h"
#include "../WeChatDLL.h"
#include "../public/Strings.h"
#include "../public/RWMutex.h"
#include "../public/Public.h"
#include <AnyCall/AnyCall.h>
#include <MyTinySTL/vector.h>

ContactModule& ContactModule::Instance()
{
	static ContactModule gContactModule;
	return gContactModule;
}

void ContactModule::InitContactModule(WeChatVersion ver)
{
	WeChatVer = ver;
}

//如何找到该函数,ContactMgr::getList

std::vector<MyContact> ContactModule::GetContactList()
{
	struct tmpVector
	{
		Contact* pVectorStart;
		Contact* pVectorLast;
		Contact* pVectorEnd;
	};

	std::vector<MyContact> retList;

	tmpVector outContactList = { 0 };
	void* gContactMgr = ContactMgr_Instance();

	switch (this->WeChatVer) {
	case WeChat_3_7_6_44:
		AnyCall::invokeThiscall<void>(gContactMgr, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x501060), &outContactList);
		break;
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>(gContactMgr, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xA98050), &outContactList);
		break;
	}

	unsigned int msgCount = (outContactList.pVectorLast - outContactList.pVectorStart);
	Contact* pStartContact = outContactList.pVectorStart;
	for (unsigned int n = 0; n < msgCount; ++n) {
		MyContact tmp = copyContact(pStartContact);
		retList.push_back(tmp);
		pStartContact->free();
		pStartContact++;
	}
	return retList;
}


//如何找到该函数,ContactMgr::getContact
MyContact ContactModule::GetContactInfoDynamic(std::wstring userName)
{
	MyContact ret;

	ContactX outContatInfo;
	mmStringX mUserName;
	mUserName.assign(userName.c_str(), userName.length());
	void* gContactMgr = ContactMgr_Instance();

	bool bFind = false;
	switch (this->WeChatVer) {
	case WeChat_3_7_6_44:
		bFind = AnyCall::invokeThiscall<bool>(gContactMgr, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x4FD560), &mUserName, &outContatInfo);
		break;
	case WeChat_3_8_0_33:
		bFind = AnyCall::invokeThiscall<bool>(gContactMgr, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xA94520), &mUserName, &outContatInfo);
		break;
	}
	if (!bFind) {
		ret.userName = userName;
		ret.nickName = userName;
		return ret;
	}
	ret = copyContact(&outContatInfo);
	if (ret.nickName == L"") {
		ret.nickName = userName;
	}
	return ret;
}


void* ContactModule::ContactMgr_Instance()
{
	switch (this->WeChatVer) {
	case WeChat_3_7_6_44:
		return AnyCall::invokeStdcall<void*>((void*)(WeChatDLL::Instance().getWinMoudule() + 0x134140));
	case WeChat_3_8_0_33:
		return AnyCall::invokeStdcall<void*>((void*)(WeChatDLL::Instance().getWinMoudule() + 0x655D60));
	}
	return NULL;
}
