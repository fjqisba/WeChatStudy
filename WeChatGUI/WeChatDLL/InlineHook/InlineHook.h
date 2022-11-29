#pragma once
#include <windows.h>

struct HookContext
{
	DWORD ELF;
	DWORD EDI;
	DWORD ESI;
	DWORD EBP;
	DWORD ESP;
	DWORD EBX;
	DWORD EDX;
	DWORD ECX;
	DWORD EAX;
};

typedef void(_stdcall * InlineFunc)(HookContext*);

//只支持x86
class InlineHook
{
public:
	InlineHook();
	~InlineHook();

	bool AddHook(LPVOID pTarget, InlineFunc func);
	bool RemoveHook();
private:
	//用于保存替换掉的5字节
	BYTE m_OldCode[5];
	//保存Hook地址,用于RemoveHook
	LPVOID m_dwHookAddr = 0;
	DWORD m_dwVirtualAddr = 0;
};

