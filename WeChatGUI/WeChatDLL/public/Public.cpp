#include "Public.h"
#include <fstream>
#include <sstream>

const char 码表[] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

std::string ReadFileToString(const char* filepath)
{
	std::string ret;
	FILE* hFile = NULL;
	if (fopen_s(&hFile, filepath, "rb")) {
		return ret;
	}
	fseek(hFile, 0, SEEK_END);
	unsigned int fileSize = ftell(hFile);
	if (!fileSize) {
		fclose(hFile);
		return ret;
	}
	fseek(hFile, 0, SEEK_SET);
	ret.resize(fileSize);
	fread(&ret[0],fileSize,1,hFile);
	fclose(hFile);
	return ret;
}

unsigned int ReadUint(void* lp)
{
	return *(unsigned int*)lp;
}

std::string ReadStdString(void* lp)
{
	if (!lp) {
		return "";
	}
	unsigned int strLen = *(unsigned int*)((char*)lp + 0x10);
	if (strLen > 0xF) {
		return *(char**)lp;
	}
	return (char*)lp;
}

std::string base64_encode(unsigned char* pBuf, unsigned int len)
{
	char BASE64_PAD = '=';
	std::string 编码结果;
	编码结果.resize((len + 2) / 3 * 4);

	int s = 0;
	unsigned int Len = 0;
	unsigned char lastC = 0;
	for (unsigned int n = 0; n < len; ++n)
	{
		unsigned char c = pBuf[n];

		switch (s)
		{
		case 0:
			s = 1;
			编码结果[Len++] = 码表[(c >> 2) & 0x3F];
			break;
		case 1:
			s = 2;
			编码结果[Len++] = 码表[((lastC & 0x3) << 4) | ((c >> 4) & 0xF)];
			break;
		case 2:
			s = 0;
			编码结果[Len++] = 码表[((lastC & 0xF) << 2) | ((c >> 6) & 0x3)];
			编码结果[Len++] = 码表[c & 0x3F];
			break;
		}
		lastC = c;
	}

	switch (s)
	{
	case 1:
		编码结果[Len++] = 码表[(lastC & 0x3) << 4];
		编码结果[Len++] = BASE64_PAD;
		编码结果[Len++] = BASE64_PAD;
		break;
	case 2:
		编码结果[Len++] = 码表[(lastC & 0xF) << 2];
		编码结果[Len++] = BASE64_PAD;
		break;
	}

	return 编码结果;
}

std::string base64_encode(std::vector<unsigned char>& 编码数据)
{
	char BASE64_PAD = '=';
	std::string 编码结果;
	编码结果.resize((编码数据.size() + 2) / 3 * 4);

	int s = 0;
	unsigned int Len = 0;
	unsigned char lastC = 0;
	for (unsigned int n = 0; n < 编码数据.size(); ++n)
	{
		unsigned char c = 编码数据[n];

		switch (s)
		{
		case 0:
			s = 1;
			编码结果[Len++] = 码表[(c >> 2) & 0x3F];
			break;
		case 1:
			s = 2;
			编码结果[Len++] = 码表[((lastC & 0x3) << 4) | ((c >> 4) & 0xF)];
			break;
		case 2:
			s = 0;
			编码结果[Len++] = 码表[((lastC & 0xF) << 2) | ((c >> 6) & 0x3)];
			编码结果[Len++] = 码表[c & 0x3F];
			break;
		}
		lastC = c;
	}

	switch (s)
	{
	case 1:
		编码结果[Len++] = 码表[(lastC & 0x3) << 4];
		编码结果[Len++] = BASE64_PAD;
		编码结果[Len++] = BASE64_PAD;
		break;
	case 2:
		编码结果[Len++] = 码表[(lastC & 0xF) << 2];
		编码结果[Len++] = BASE64_PAD;
		break;
	}

	return 编码结果;
}