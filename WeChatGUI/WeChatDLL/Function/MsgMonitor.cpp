#include "MsgMonitor.h"
#include <json.hpp>
#include <fstream>
#include <vector>
#include <httplib.h>
#include <AnyCall/AnyCall.h>
#include "../InlineHook/InlineHook.h"
#include "../WeChatDLL.h"
#include "../TinyXml/tinyxml2.h"
#include "../public/Strings.h"
#include "../public/Public.h"
#include "../public/WinApi.h"
#include "../WeChat/ChatMsg.h"
#include "../WeChat/ChatRoom.h"
#include "../WeChatDLL.h"
#include "../微信偏移.h"
#include "ContactFunction.h"
#include "AccountFunction.h"
#include "../proto/ChatRoom.pb.h"

InlineHook gHook_AddChatMsg;
InlineHook gHook_ImageDownload;
InlineHook gHook_GetChatroomMemberDetail;
InlineHook gHook_AddChatroomChangeList;

//普通消息
void AddJsonMsg_Normal(MyChatMsg& chatMsg,std::wstring& content)
{
	MsgUploadInfo tmpMsg;
	tmpMsg.msg["msg_type"] = chatMsg.msgType;
	tmpMsg.msg["msg_id"] = chatMsg.msgID;
	tmpMsg.msg["robot_id"] = UnicodeToUtf8(AccountFunction::Instance().getCurrentUserWxid().c_str());
	tmpMsg.msg["post_time"] = chatMsg.CreateTime;
	tmpMsg.msg["wxid"] = UnicodeToUtf8(chatMsg.FromUserName.c_str());
	if (!chatMsg.FromUserName.empty()) {
		tmpMsg.msg["name"] = UnicodeToUtf8(ContactModule::Instance().GetContactInfoDynamic(chatMsg.FromUserName).nickName.c_str());
	}
	tmpMsg.msg["sender_wxid"] = UnicodeToUtf8(chatMsg.sendWxid.c_str());
	tmpMsg.msg["sender_name"] = UnicodeToUtf8(ContactModule::Instance().GetContactInfoDynamic(chatMsg.sendWxid).nickName.c_str());
	tmpMsg.msg["msg_content"] = UnicodeToUtf8(content.c_str());
	MsgMonitor::Instance().AddMsg(tmpMsg);
}

void HandleMsg_10000(MyChatMsg& chatMsg)
{
	//if (endsWith(chatMsg.msgContent, L"移出了群聊") == true) {
	//	//个人将群员移除群聊
	//	return;
	//}



	int a = 0;
}

//void handleMsg_delchatroommember(MyChatMsg& chatMsg)
//{
//	std::string tmpMsg = UnicodeToUtf8(chatMsg.msgContent.c_str());
//	tinyxml2::XMLDocument xmlDocument;
//	if (xmlDocument.Parse(tmpMsg.c_str()) != tinyxml2::XMLError::XML_SUCCESS) {
//		WeChatDLL::Instance().MsgRecvLogger()->error("[HandleMsg_10002]解析消息失败:" + tmpMsg);
//		return;
//	}
//	tinyxml2::XMLElement* elementMsg = xmlDocument.FirstChildElement("sysmsg");
//	if (!elementMsg) {
//		return;
//	}
//	elementMsg = elementMsg->FirstChildElement("delchatroommember");
//	if (!elementMsg) {
//		return;
//	}
//	elementMsg = elementMsg->FirstChildElement("link");
//	if (!elementMsg) {
//		return;
//	}
//	elementMsg = elementMsg->FirstChildElement("memberlist");
//	if(!elementMsg){
//		return;
//	}
//	tinyxml2::XMLNode* currentUserName = elementMsg->FirstChild();
//	while (currentUserName) {
//		elementMsg = currentUserName->ToElement();
//		if (elementMsg) {
//			std::string userWxid = elementMsg->GetText();
//			
//		}
//		currentUserName = currentUserName->NextSibling();
//	}
//}

void HandleMsg_10002(MyChatMsg& chatMsg)
{
	//if (startsWith(chatMsg.msgContent, L"<sysmsg type=\"delchatroommember\">")) {
	//	handleMsg_delchatroommember(chatMsg);
	//	return;
	//}
	int a = 0;
}


//如何找到该函数,NetSceneGetMsgImgCDN::onDownloadSuccessed

void __stdcall MyOnDownloadImageSuccessed_3_7_6_44(HookContext* hookContext)
{
	char* pNetSceneGetMsgImgCDN = (char*)hookContext->ECX;
	ChatMsg* pChatMsg = (ChatMsg*)(pNetSceneGetMsgImgCDN + 0x5AC);
	MyChatMsg tmpMsg = CopyChatMsg(pChatMsg);
	mmString* pImageDownloadPath = (mmString*)(pNetSceneGetMsgImgCDN + 0x954);
	tmpMsg.imagePath = copyMMString(pImageDownloadPath);
	if (tmpMsg.IsOwner) {
		tmpMsg.sendWxid = AccountFunction::Instance().getCurrentUserWxid();
	}
	AddJsonMsg_Normal(tmpMsg, tmpMsg.imagePath);
}

void __stdcall MyOnDownloadImageSuccessed_3_8_0_33(HookContext* hookContext)
{
	char* pNetSceneGetMsgImgCDN = (char*)hookContext->ECX;
	ChatMsg* pChatMsg = (ChatMsg*)(pNetSceneGetMsgImgCDN + 0x5AC);
	MyChatMsg tmpMsg = CopyChatMsg(pChatMsg);
	mmString* pImageDownloadPath = (mmString*)(pNetSceneGetMsgImgCDN + 0x964);
	tmpMsg.imagePath = copyMMString(pImageDownloadPath).c_str();
	if (tmpMsg.IsOwner) {
		tmpMsg.sendWxid = AccountFunction::Instance().getCurrentUserWxid();
	}
	AddJsonMsg_Normal(tmpMsg, tmpMsg.imagePath);
}

void __stdcall MyAddChatMsg(HookContext* hookContext)
{
	ChatMsg* pChatMsg = (ChatMsg*)hookContext->ECX;
	if (pChatMsg->msgType == 51) {
		return;
	}
	MyChatMsg tmpMsg = CopyChatMsg(pChatMsg);
	if (tmpMsg.IsOwner) {
		tmpMsg.sendWxid = AccountFunction::Instance().getCurrentUserWxid();
	}
	switch (tmpMsg.msgType)
	{
	case 1:			//普通消息	
	case 42:		//名片消息
	case 43:		//视频消息
	case 47:		//表情消息
	case 49:		//应用消息
		AddJsonMsg_Normal(tmpMsg,tmpMsg.msgContent);
		break;
	case 10000:		//系统通知 + 他人邀请好友入群
		HandleMsg_10000(tmpMsg);
		break;
	case 10002:		//自己邀请好友入群
		HandleMsg_10002(tmpMsg);
		break;
	case 3:
		//不在这里处理图片消息
		break;
	default:
		break;
	}
}

//如何找到该函数,GetChatroomMemberDetailResponse>::buf2Resp
void __stdcall MyGetChatroomMemberDetail(HookContext* hookContext)
{
	char* pResponseBuf = *(char**)hookContext->ESP;
	int respLen = *(int*)(hookContext->ESP + 4);
	GetChatroomMemberDetailResponse memberDetailResp;
	if (!memberDetailResp.ParseFromArray(pResponseBuf, respLen)) {
		WeChatDLL::Instance().MsgRecvLogger()->error(BinToHex((unsigned char*)pResponseBuf,respLen));
		return;
	}
	int memberCount = memberDetailResp.newchatroomdata().membercount();
	if (!memberCount) {
		return;
	}
	MsgMonitor& gMsgMonitor = MsgMonitor::Instance();
	auto memberList = memberDetailResp.newchatroomdata().chatroommember();
	for (int n = 0; n < memberList.size(); ++n) {
		MsgUploadInfo addMemberMsg;
		std::wstring eventName = Utf8ToUnicode(memberDetailResp.chatroomusername().c_str()) + L"_" + Utf8ToUnicode(memberList[n].username().c_str());
		if (!gMsgMonitor.getAddMemberEventMsg(eventName, addMemberMsg)) {
			continue;
		}
		addMemberMsg.msg["inviter_wxid"] = memberList[n].inviterusername();
		MsgMonitor::Instance().AddMsg(addMemberMsg);
	}
}

bool MsgMonitor::getAddMemberEventMsg(std::wstring& eventName, MsgUploadInfo& outInfo)
{
	std::lock_guard<std::mutex> lock(this->addEventMutex);
	std::map<std::wstring, MsgUploadInfo>::iterator it = this->addMemberEventMap.find(eventName);
	if (it == this->addMemberEventMap.end()) {
		return false;
	}
	outInfo = it->second;
	this->addMemberEventMap.erase(it);
	return true;
}

void MsgMonitor::setAddMemberEventMsg(std::wstring& eventName,MsgUploadInfo& msg)
{
	std::lock_guard<std::mutex> lock(this->addEventMutex);
	this->addMemberEventMap[eventName] = msg;
}

//如何找到该函数,AddChatroomChangeList
void __stdcall MyAddChatroomChangeList(HookContext* hookContext)
{
	ChatroomDiffList* pChatroomDiffList = *(ChatroomDiffList**)(hookContext->ESP + 0x4);

	std::wstring chatRoomID = copyMMString(&pChatroomDiffList->chatRoomID);
	MsgMonitor& gMsgMonitor = MsgMonitor::Instance();
	for (unsigned int n = 0; n < pChatroomDiffList->addUserList.size(); n++) {
		std::wstring addUserWxid = copyMMString(&pChatroomDiffList->addUserList[n].memberWxid);
		MsgUploadInfo tmpMsg;
		tmpMsg.msg["msg_type"] = WX_ChatRoomMemberInvite;
		tmpMsg.msg["robot_id"] = UnicodeToUtf8(AccountFunction::Instance().getCurrentUserWxid().c_str());
		tmpMsg.msg["event_time"] = time(NULL);
		tmpMsg.msg["chatroom_id"] = UnicodeToUtf8(chatRoomID.c_str());
		tmpMsg.msg["member_wxid"] = UnicodeToAnsi(addUserWxid.c_str());

		std::wstring addEventName = chatRoomID + L"_" + addUserWxid;
		gMsgMonitor.setAddMemberEventMsg(addEventName, tmpMsg);
	}

	for (unsigned int n = 0; n < pChatroomDiffList->delelteUserList.size(); n++) {
		std::wstring deleteUserWxid = copyMMString(&pChatroomDiffList->delelteUserList[n].memberWxid);
		MsgUploadInfo tmpMsg;
		tmpMsg.msg["msg_type"] = WX_ChatRoomMemberLeave;
		tmpMsg.msg["robot_id"] = UnicodeToUtf8(AccountFunction::Instance().getCurrentUserWxid().c_str());
		tmpMsg.msg["event_time"] = time(NULL);
		tmpMsg.msg["chatroom_id"] = UnicodeToUtf8(chatRoomID.c_str());
		tmpMsg.msg["member_wxid"] = UnicodeToAnsi(deleteUserWxid.c_str());
		MsgMonitor::Instance().AddMsg(tmpMsg);
	}
}

MsgMonitor& MsgMonitor::Instance()
{
	static MsgMonitor gMsgMonitor;
	return gMsgMonitor;
}

bool MsgMonitor::InitMsgMonitor(WeChatVersion v)
{
	WeChatVer = v;

	DWORD hWeChatWinDLL = WeChatDLL::Instance().getWinMoudule();
	
	switch (WeChatVer) {
	case WeChat_3_7_6_44:
		gHook_AddChatMsg.AddHook((LPVOID)(hWeChatWinDLL + 0x5F7423), MyAddChatMsg);
		gHook_ImageDownload.AddHook((LPVOID)(hWeChatWinDLL + 0x6C0D50), MyOnDownloadImageSuccessed_3_7_6_44);
		//开启图片自动下载
		写内存_HEX(-1, hWeChatWinDLL + 0x5262B0, "B001C3");
		return true;
	case WeChat_3_8_0_33:
		gHook_AddChatMsg.AddHook((LPVOID)(hWeChatWinDLL + 0xB94296), MyAddChatMsg);
		gHook_ImageDownload.AddHook((LPVOID)(hWeChatWinDLL + 0xC63740), MyOnDownloadImageSuccessed_3_8_0_33);
		//开启图片自动下载
		写内存_HEX(-1, hWeChatWinDLL + 0xB94344, "E9CE00");

		//群成员变动监控
		gHook_GetChatroomMemberDetail.AddHook((LPVOID)(hWeChatWinDLL + 0xC38A29), MyGetChatroomMemberDetail);
		gHook_AddChatroomChangeList.AddHook((LPVOID)(hWeChatWinDLL + 0xD403B0),MyAddChatroomChangeList);
		return true;
	default:
		break;
	}
	return false;
}

std::vector<MsgUploadInfo> MsgMonitor::SyncMsg()
{
	std::vector<MsgUploadInfo> retMsgList;
	msgBuffer.popMsg(retMsgList);
	return retMsgList;
}

void MsgMonitor::AddMsg(MsgUploadInfo& msg)
{
	msgBuffer.pushMsg(msg);
}

MsgBuffer::MsgBuffer()
{
	
}

inline void MsgBuffer::pushMsg(MsgUploadInfo& msg)
{
	mute.lock();
	if (buffer.size() >= 1000) {
		buffer.pop_front();
	}
	buffer.push_back(msg);
	mute.unlock();
}

void MsgBuffer::popMsg(std::vector<MsgUploadInfo>& outMsgList)
{
	mute.lock();
	unsigned int msgCount = 0;
	for (std::list<MsgUploadInfo>::iterator it = buffer.begin(); it != buffer.end(); ++it) {
		outMsgList.push_back(*it);
		if (++msgCount >= 10) {
			break;
		}
	}
	for (unsigned int n = 0; n < msgCount; ++n) {
		buffer.pop_front();
	}
	mute.unlock();
	return;
}
