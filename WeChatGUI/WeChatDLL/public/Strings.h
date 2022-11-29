#pragma once
#include <string>
#include <vector>

//十六进制字符串转字节集
std::vector<unsigned char> HexStrToBin(std::string& HexCode);

//字节集转十六进制字符串
std::string BinToHex(unsigned char* pBuf, unsigned int len);


bool startsWith(const std::wstring& str, const std::wstring prefix);

bool endsWith(const std::wstring& str, const std::wstring suffix);

std::string ReplaceString(std::string& str,std::string to_replaced,const std::string& newchars);

std::string UnicodeToAnsi(const wchar_t* szStr);

std::string UnicodeToUtf8(const wchar_t* szStr);

std::wstring AnsiToUnicode(const char* szStr);

std::wstring Utf8ToUnicode(const char* szStr);

//转utf8
std::string LocalCpToUtf8(const char* str);