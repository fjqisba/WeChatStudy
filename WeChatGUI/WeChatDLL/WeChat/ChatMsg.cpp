#include "ChatMsg.h"
#include "../public/Strings.h"
#include "../WeChatDLL.h"
#include <AnyCall/AnyCall.h>

MyChatMsg CopyChatMsg(ChatMsg* pChatMsg)
{
	MyChatMsg ret;
	ret.msgType = pChatMsg->msgType;
	ret.msgID = pChatMsg->newMsgId;
	ret.IsOwner = pChatMsg->isOwner;
	ret.FromUserName = copyMMString(&pChatMsg->fromUserName);
	if (!pChatMsg->isOwner) {
		ret.sendWxid = copyMMString(&pChatMsg->mixExtra.sendWxid);
	}
	ret.msgContent = copyMMString(&pChatMsg->msgContent);
	ret.CreateTime = pChatMsg->createTime;
	ret.imagePath = copyMMString(&pChatMsg->mixExtra.imagePath);
	return ret;
}

ChatMsgX::ChatMsgX()
{
	
}

//如何找到析构函数,AppMsgMgr::sendFile
ChatMsgX::~ChatMsgX()
{
	switch (WeChatDLL::Instance().getWechatVersion()) {
	case WeChat_3_7_6_44:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x131EB0));
		return;
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0x651C40));
		return;
	}

}
