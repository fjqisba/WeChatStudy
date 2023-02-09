#pragma once
#include <vector>
#include <string>
#include <windows.h>

std::string ReadFileToString(const char* filepath);

unsigned int ReadUint(void*);

std::string ReadStdString(void*);

std::string base64_encode(std::vector<unsigned char>& bufData);

std::string base64_encode(unsigned char* pBuf,unsigned int len);

