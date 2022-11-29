#include "WinApi.h"
#include "Strings.h"
#include <winver.h>

#pragma comment(lib,"version.lib") 


bool Ð´ÄÚ´æ_HEX(DWORD hProcess, size_t addr, std::string hex)
{
	std::vector<unsigned char> bin = HexStrToBin(hex);
	return WriteProcessMemory((HANDLE)hProcess, (LPVOID)addr, bin.data(), bin.size(), 0);
}

std::string getModulePath(HMODULE hModule)
{
	char szBuff[MAX_PATH] = { 0 };
	GetModuleFileNameA(hModule,szBuff,MAX_PATH);
	return szBuff;
}

std::string getFileVersion(const char* filePath)
{
	std::string retVer;
	DWORD dwHnd;
	DWORD dwVerInfoSize;
	dwVerInfoSize = GetFileVersionInfoSizeA(filePath, &dwHnd);
	if (dwVerInfoSize <= 0) {
		return retVer;
	}
	char* buf = new char[dwVerInfoSize];
	memset(buf, 0x0, dwVerInfoSize);
	if (!buf) {
		return retVer;
	}
	do 
	{
		if (!GetFileVersionInfoA(filePath, dwHnd, dwVerInfoSize, buf)) {
			break;
		}
		VS_FIXEDFILEINFO* pVsInfo;
		unsigned int version_len = 0;
		if (!VerQueryValueA(buf, "\\", (void**)&pVsInfo, &version_len)) {
			break;
		}
		sprintf(buf, "%d.%d.%d.%d", HIWORD(pVsInfo->dwFileVersionMS),
			LOWORD(pVsInfo->dwFileVersionMS),
			HIWORD(pVsInfo->dwFileVersionLS),
			LOWORD(pVsInfo->dwFileVersionLS));
		retVer.assign(buf);
	} while (0);
	delete buf;
	return retVer;
}
