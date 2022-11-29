#pragma once
#include <string>
#include <vector>

//原生结构体,用于读
struct mmString
{
public:
	mmString();
	void free();
	void assignUTF8(const char* src);
	//用微信自己的alloc
	void assign(const wchar_t* src, int len);
public:
	wchar_t* pUnicode;
	int Mysize;
	int Myres;
	char* pUTF8;
	int uLen;
};

std::wstring copyMMString(mmString* mmStr);

//封装结构体,相比原生结构体增加了析构函数和拷贝构造函数呢
struct mmStringX :public mmString
{
public:
	mmStringX();
	//拷贝构造函数
	mmStringX(const mmStringX& obj);
	~mmStringX();
};
