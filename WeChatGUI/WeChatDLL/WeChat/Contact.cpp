#include "Contact.h"
#include "../public/Strings.h"
#include "../WeChatDLL.h"
#include <AnyCall/AnyCall.h>

MyContact copyContact(Contact* pContact)
{
	MyContact ret;
	ret.userName = copyMMString(&pContact->userName);
	ret.alias = copyMMString(&pContact->alias);
	ret.encryptUserName = copyMMString(&pContact->encryptUserName);
	ret.remark = copyMMString(&pContact->remark);
	ret.nickName = copyMMString(&pContact->nickName);
	return ret;
}

Contact::Contact()
{
	switch (WeChatDLL::Instance().getWechatVersion()) {
	case WeChat_3_7_6_44:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x76CBC0));
		return;
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xD10690));
		return;
	}
}

void Contact::free()
{
	switch (WeChatDLL::Instance().getWechatVersion()) {
	case WeChat_3_7_6_44:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x76D6C0));
		return;
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xD11190));
		return;
	}
}

ContactX::ContactX()
{

}

ContactX::~ContactX()
{
	free();
}
