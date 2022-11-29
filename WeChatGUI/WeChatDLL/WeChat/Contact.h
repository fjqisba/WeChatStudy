#pragma once
#include <windows.h>
#include "common.h"

//微信原始结构体,大小为0x3E8
//如何判断结构体大小,ContactMgr::GetNormalContactList
struct Contact
{
	DWORD vtable;
	int unknow_4;
	int unknow_8;
	int unknow_c;
	mmString userName;
	mmString alias;
	mmString encryptUserName;
	int delFlag;
	int type;
	int verifyFlag;
	mmString remark;
	mmString nickName;
	mmString labelIDList;
	mmString domainList;
	int chatroomType;  //推测
	mmString pyInitial;
	mmString quanpin;
	mmString remarkPYInitial;
	mmString remarkQuanPin;
	mmString bigHeadImgUrl;
	mmString smallHeadImgUrl;
	int field_124;
	int field_128;
	int field_12C;
	int field_130;
	int field_134;
	int field_138;
	int field_13C;
	int field_140;
	int reserved1_144;
	int reserved2_148;
	int field_14C;
	int extraBuf;
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
	int field_180;
	int field_184;
	int field_188;
	int field_18C;
	int field_190;
	int field_194;
	int field_198;
	int field_19C;
	int field_1A0;
	int field_1A4;
	int field_1A8;
	int field_1AC;
	int field_1B0;
	int field_1B4;
	int field_1B8;
	int field_1BC;
	int field_1C0;
	int field_1C4;
	int field_1C8;
	int field_1CC;
	int field_1D0;
	int field_1D4;
	int field_1D8;
	int field_1DC;
	int field_1E0;
	int field_1E4;
	int field_1E8;
	int field_1EC;
	int field_1F0;
	int field_1F4;
	int field_1F8;
	int field_1FC;
	int field_200;
	int field_204;
	int field_208;
	int field_20C;
	int field_210;
	int field_214;
	int field_218;
	int field_21C;
	int field_220;
	int field_224;
	int field_228;
	int field_22C;
	int field_230;
	int field_234;
	int field_238;
	int field_23C;
	int field_240;
	int field_244;
	int field_248;
	int field_24C;
	int field_250;
	int field_254;
	int field_258;
	int field_25C;
	int field_260;
	int field_264;
	int field_268;
	int field_26C;
	int field_270;
	int field_274;
	int field_278;
	int field_27C;
	int field_280;
	int field_284;
	int field_288;
	int field_28C;
	int field_290;
	int field_294;
	int field_298;
	int field_29C;
	int field_2A0;
	int field_2A4;
	int field_2A8;
	int field_2AC;
	int field_2B0;
	int field_2B4;
	int field_2B8;
	int field_2BC;
	int field_2C0;
	int field_2C4;
	int field_2C8;
	int field_2CC;
	int field_2D0;
	int field_2D4;
	int field_2D8;
	int field_2DC;
	int field_2E0;
	int field_2E4;
	int field_2E8;
	int field_2EC;
	int field_2F0;
	int field_2F4;
	int field_2F8;
	int field_2FC;
	int field_300;
	int Reserved6;
	int field_308;
	int field_30C;
	int field_310;
	int field_314;
	int field_318;
	int field_31C;
	int field_320;
	int field_324;
	int field_328;
	mmString field_32C;
	int field_340;
	int field_344;
	int field_348;
	mmString field_34C;
	mmString field_360;
	mmString field_374;
	int field_388;
	int field_38C;
	int field_390;
	int field_394;
	int field_398;
	int field_39C;
	int field_3A0;
	char field_3A4;
	char field_3A5;
	char field_3A6;
	char field_3A7;
	mmString field_3A8;
	mmString field_3BC;
	mmString field_3D0;
	char field_3E4;
	char field_3E5;
	char field_3E6;
	char field_3E7;

	Contact();
	void free();
};

struct ContactX : public Contact
{
public:
	ContactX();
	~ContactX();
};

//转换结构体
struct MyContact
{
	std::wstring userName;
	std::wstring alias;
	std::wstring encryptUserName;
	std::wstring remark;
	std::wstring nickName;
};

MyContact copyContact(Contact* pContact);


