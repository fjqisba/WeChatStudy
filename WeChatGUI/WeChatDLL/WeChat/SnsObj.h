#pragma once
#include "common.h"

struct SnsMedia
{
	unsigned long long id;
	unsigned int type;
	unsigned int unknow_C;
	unsigned int unknow_10;
	unsigned int unknow_14;
	unsigned int unknow_18;
	unsigned int unknow_1C;
	mmString description;
	int field_34;
	mmString urlMD5;
	int field_4C;
	mmString Url;
	int field_64;
	mmString ThumbUrl;
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
	int field_A4;
	int field_A8;
	int field_AC;
	int field_B0;
	int field_B4;
	int field_B8;
	int field_BC;
	int field_C0;
	int field_C4;
	int field_C8;
	int field_CC;
	int field_D0;
	int field_D4;
	int field_D8;
	int field_DC;
	int field_E0;
	int field_E4;
};

struct SnsContentObject
{
	int contentStyle;
	int field_4;
	mmString title;
	mmString description;
	mmString contentUrl;
	SnsMedia* pSnsMediaStart;
	SnsMedia* pSnsMediaLast;
	SnsMedia* pSnsMediaEnd;
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
	int field_A4;
	int field_A8;
	int field_AC;
	int field_B0;
	int field_B4;
	int field_B8;
	int field_BC;
	int field_C0;
	int field_C4;
	int field_C8;
	int field_CC;
	int field_D0;
	int field_D4;
	int field_D8;
	int field_DC;
	int field_E0;
	int field_E4;
	int field_E8;
	int field_EC;
	int field_F0;
	int field_F4;
	int field_F8;
	int field_FC;
	int field_100;
	int field_104;
	int field_108;
	int field_10C;
	int field_110;
	int field_114;
	int field_118;
	int field_11C;
	int field_120;
	int field_124;
	int field_128;
	int field_12C;
	int field_130;
	int field_134;
	int field_138;
	int field_13C;
	int field_140;
	int field_144;
	int field_148;
	int field_14C;
	int field_150;
	int field_154;
	int field_158;
	int field_15C;
	int field_160;
	int field_164;
};


struct TimelineMsg
{
	unsigned long long id;
	mmString senderName;
	int sendTime;
	int Guess_contentDescShowType;
	int contentDescScene;
	int field_28;
	mmString contentDesc;
	mmString uuknow_40;
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
	int field_A4;
	int field_A8;
	int field_AC;
	int field_B0;
	int field_B4;
	int field_B8;
	int field_BC;
	int field_C0;
	int field_C4;
	int field_C8;
	int field_CC;
	int field_D0;
	int field_D4;
	int field_D8;
	int field_DC;
	int field_E0;
	int field_E4;
	int field_E8;
	int field_EC;
	int field_F0;
	int field_F4;
	int field_F8;
	int field_FC;
	int field_100;
	int field_104;
	int field_108;
	int field_10C;
	int field_110;
	int field_114;
	int field_118;
	int field_11C;
	int field_120;
	int field_124;
	int field_128;
	int field_12C;
	int field_130;
	int field_134;
	int field_138;
	int field_13C;
	int field_140;
	int field_144;
	int field_148;
	int field_14C;
	int field_150;
	int field_154;
	int field_158;
	int field_15C;
	int field_160;
	int field_164;
	int field_168;
	int field_16C;
	int field_170;
	int field_174;
	int field_178;
	int field_17C;
	SnsContentObject contentObject;
	int field_2E8;
	int field_2EC;
	int field_2F0;
	int field_2F4;
	int field_2F8;
	int field_2FC;
	int field_300;
	int field_304;
	int field_308;
};

//结构体大小为0xB48
//如何判断结构体大小,SnsTimeLineMgr::OnSnsTimeLineSceneFinish
struct TimelineResp
{
	unsigned long long id;
	unsigned int nouse_8;
	unsigned int nouse_C;
	TimelineMsg coreMsg;
	char tmpBuf[2088];
};

struct MySnsMedia
{
	unsigned long long id;
	unsigned int type;
	std::wstring description;
	std::wstring url;
};

struct MyTimeLineResp
{
	//每条消息都有一个唯一id
	unsigned long long id;
	//消息发送时间
	unsigned int sendTime;
	//消息发送者的名称
	std::wstring sendWxid;
	//消息显示内容
	std::wstring content;
	//描述
	std::wstring title;
	std::wstring description;
	std::wstring contentUrl;
	//多媒体
	std::vector<MySnsMedia> mediaList;
};


MyTimeLineResp CopyTimeLineResp(TimelineResp* pTimelineResp);

