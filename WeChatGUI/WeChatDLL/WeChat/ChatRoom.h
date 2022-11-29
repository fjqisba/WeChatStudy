#pragma once
#include "common.h"
#include "MyTinySTL/vector.h"

#pragma pack (push,1)

struct ChatroomDiffParam
{
	int field_0;
	int field_4;
	int field_8;
	int field_C;
	int field_10;
	mmString memberWxid;
	int field_28;
	int field_2C;
	int field_30;
	int field_34;
	int field_38;
	int field_3C;
};

struct ChatroomDiffList
{
	mmString chatRoomID;
	int field_14;
	mystl::vector<ChatroomDiffParam> delelteUserList;
	int field_24;
	int field_28;
	int field_2C;
	mystl::vector<ChatroomDiffParam> addUserList;
	char flag_3C;
	char field_3D;
	char field_3E;
	char field_3F;
};

#pragma pack(pop)

//结构体大小,是0x19C
struct ChatRoom
{
	char buffer[0x19C];
public:
	void getMemberList(void* outMemberList);
	std::string getOldMemberStr();
};

struct ChatRoomX:public ChatRoom
{
public:
	ChatRoomX();
	~ChatRoomX();
};

//结构体大小,猜测是0xA4
struct ChatRoomInfo
{
	int field_0;
	int field_4;
	int field_8;
	int field_C;
	int field_10;
	int field_14;
	int field_18;
	int field_1C;
	int field_20;
	int field_24;
	int field_28;
	int field_2C;
	int field_30;
	int field_34;
	int field_38;
	int field_3C;
	int field_40;
	int field_44;
	int field_48;
	int field_4C;
	int field_50;
	int field_54;
	int field_58;
	int field_5C;
	int field_60;
	int field_64;
	int field_68;
	int field_6C;
	int field_70;
	int field_74;
	int field_78;
	int field_7C;
	int field_80;
	int field_84;
	int field_88;
	int field_8C;
	int field_90;
	int field_94;
	int field_98;
	int field_9C;
	int field_A0;
};

void* AccountStorageMgr_chatRoomStorage();
bool chatRoomStorage_getChatRoom(void* pChatRoomStorage, mmStringX* chatRoomID, ChatRoomX* outChatRoom);

