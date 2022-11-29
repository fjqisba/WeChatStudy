#include "ChatRoom.h"
#include "../WeChatDLL.h"
#include <AnyCall/AnyCall.h>

//如何找到该函数,直接搜索字符串
void* AccountStorageMgr_chatRoomStorage()
{
	switch (WeChatDLL::Instance().getWechatVersion())
	{
	case WeChat_3_8_0_33:
		return AnyCall::invokeStdcall<void*>((void*)(WeChatDLL::Instance().getWinMoudule() + 0xB0B220));
	default:
		break;
	}
	return NULL;
}

//如何找到该函数,直接搜索字符串ChatRoomMgr::updateChatRoomDetail,你需要主动释放ChatRoom
bool chatRoomStorage_getChatRoom(void* pChatRoomStorage, mmStringX* chatRoomID, ChatRoomX* outChatRoom)
{
	switch (WeChatDLL::Instance().getWechatVersion())
	{
	case WeChat_3_8_0_33:
		return AnyCall::invokeThiscall<void*>(pChatRoomStorage, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xD07A60), chatRoomID, outChatRoom);
	default:
		break;
	}
	return false;
}


std::string ChatRoom::getOldMemberStr()
{
	switch (WeChatDLL::Instance().getWechatVersion())
	{
	case WeChat_3_8_0_33:
		return *(char**)&this->buffer[0x1C];
	default:
		break;
	}
	return "";
}

void ChatRoom::getMemberList(void* outMemberList)
{
	switch (WeChatDLL::Instance().getWechatVersion())
	{
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xD02180),outMemberList);
	default:
		break;
	}
	return;
}

ChatRoomX::ChatRoomX()
{
	switch (WeChatDLL::Instance().getWechatVersion())
	{
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xD016C0));
	default:
		break;
	}
	return;
}

ChatRoomX::~ChatRoomX()
{
	switch (WeChatDLL::Instance().getWechatVersion())
	{
	case WeChat_3_8_0_33:
		AnyCall::invokeThiscall<void>((void*)this, (void*)(WeChatDLL::Instance().getWinMoudule() + 0xD018E0));
	default:
		break;
	}
	return;
}