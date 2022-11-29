#include <iostream>
#include <windows.h>

bool InjectWeChatDLL(std::string exePath, std::string dllPath)
{
	STARTUPINFOA si;
	PROCESS_INFORMATION pi;

	ZeroMemory(&si, sizeof(si));
	si.cb = sizeof(si);
	ZeroMemory(&pi, sizeof(pi));

	if (CreateProcessA(exePath.c_str(), NULL, NULL, NULL, false, CREATE_SUSPENDED, NULL, NULL, &si, &pi) == false) {
		return false;
	}

	LPVOID lpThreadFun, ptszRemoteBuf;
	HANDLE hThread;
	bool bOK = true;

	GetModuleHandle(0);

	do
	{
		lpThreadFun = GetProcAddress(GetModuleHandleA("kernel32.dll"), "LoadLibraryA");

		ptszRemoteBuf = VirtualAllocEx(pi.hProcess, 0, 0x1000, MEM_COMMIT | MEM_TOP_DOWN, PAGE_EXECUTE_READWRITE);
		if (ptszRemoteBuf == 0) {
			bOK = false;
			break;
		}
		if (WriteProcessMemory(pi.hProcess, ptszRemoteBuf, dllPath.c_str(), dllPath.size(), 0) == false) {
			bOK = false;
			break;
		}
		hThread = CreateRemoteThread(pi.hProcess, NULL, 0, (LPTHREAD_START_ROUTINE)lpThreadFun, ptszRemoteBuf, 0, NULL);
		if (hThread == NULL) {
			bOK = false;
			break;
		}
		WaitForSingleObject(hThread, INFINITE);
	} while (0);

	if (bOK == false) {
		TerminateProcess(pi.hProcess, 0);
	}
	else {
		ResumeThread(pi.hThread);
		CloseHandle(pi.hProcess);
		CloseHandle(pi.hThread);
	}

	return bOK;
}
int main()
{
	std::string wechatPath = R"(C:\App\WeChat\[3.7.6.44]\WeChat.exe)";
	std::string dllPath = R"(C:\App\WeChat\[3.7.6.44]\WeChatDLL.dll)";

	InjectWeChatDLL(wechatPath, dllPath);

	return true;
}