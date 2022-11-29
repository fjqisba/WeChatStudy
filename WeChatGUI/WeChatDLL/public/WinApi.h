#pragma once
#include <windows.h>
#include <string>

bool 写内存_HEX(DWORD hProcess,size_t addr,std::string hex);

//取模块路径
std::string getModulePath(HMODULE hModule);

//取文件版本
std::string getFileVersion(const char* filePath);