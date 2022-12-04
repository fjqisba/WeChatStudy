#pragma once
#include <vector>
#include <string>
#include <list>
#include <mutex>
#include <nlohmann/json.hpp>
#include "../public/RWMutex.h"

enum msgCategory
{
	WX_Unknow = 0x0,
	//登录二维码消息
	WX_LoginQRCodeMsg = 20000,
	//登录成功后,同步用户信息
	WX_SyncUserProfile = 20001,

	//群聊成员增加
	WX_ChatRoomMemberInvite = 20010,
	//群聊成员减少
	WX_ChatRoomMemberLeave = 20011,
};

struct MsgUploadInfo
{
	nlohmann::json msg;
};

class MsgBuffer
{
public:
	MsgBuffer();
	void pushMsg(MsgUploadInfo& msg);
	void popMsg(std::vector<MsgUploadInfo>& outMsgList);
private:
	std::list<MsgUploadInfo> buffer;
	std::mutex mute;
};

enum WeChatVersion;
class MsgMonitor
{
public:
	static MsgMonitor& Instance();
	bool InitMsgMonitor(WeChatVersion ver);
	std::vector<MsgUploadInfo> SyncMsg();
	void AddMsg(MsgUploadInfo& msg);

	//获取群成员事件
	bool getAddMemberEventMsg(std::wstring& eventName, MsgUploadInfo& outInfo);
	//添加群成员事件
	void setAddMemberEventMsg(std::wstring& eventName,MsgUploadInfo& msg);
private:
	WeChatVersion WeChatVer;
	MsgBuffer msgBuffer;

	//事件消息表
	std::map<std::wstring, MsgUploadInfo> addMemberEventMap;
	std::mutex addEventMutex;
};