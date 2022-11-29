//中文
#include "微信多开.h"
#include "../微信偏移.h"
#include "../public/WinApi.h"
#include "../WeChatDLL.h"

bool Patch_微信多开(WeChatVersion ver)
{
	//特征cmp eax, 0B7h的下一句
	switch (ver) {
	case WeChat_3_7_6_44:
		return 写内存_HEX(-1, WeChatDLL::Instance().getWinMoudule() + 0xE7FCBE, "EB");
	case WeChat_3_8_0_33:
		return 写内存_HEX(-1, WeChatDLL::Instance().getWinMoudule() + 0x1477F84, "EB");
		return true;
	}
	return false;
}
