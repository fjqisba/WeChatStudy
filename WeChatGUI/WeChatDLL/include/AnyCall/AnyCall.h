#pragma once

namespace AnyCall
{
	template <typename T, typename... Args>
	T invokeStdcall(void* functionAddress, Args... args) noexcept
	{
		typedef T(__stdcall* stdFuncDef)(Args...);
		stdFuncDef f = (stdFuncDef)functionAddress;
		return f(args...);
	}

	template <typename T, typename... Args>
	T invokeCdecl(void* functionAddress, Args... args) noexcept
	{
		typedef T(__cdecl* cDeclFuncDef)(Args...);
		cDeclFuncDef f = (cDeclFuncDef)functionAddress;
		return f(args...);
	}

	template<typename R, typename... Args>
	R invokeThiscall(void* ecx, void* address, Args...args) noexcept
	{
		typedef R(__thiscall* thisFuncDef)(void*, Args...);
		thisFuncDef function = (thisFuncDef)address;
		return function(ecx, args...);
	}

	template<typename R, typename... Args>
	R invokeFastcall(void* ecx, void* edx, void* address, Args...args) noexcept
	{
		typedef R(__fastcall* fastFuncDef)(void*,void*, Args...);
		fastFuncDef function = (fastFuncDef)address;
		return function(ecx, edx, args...);
	}

	//为了应付特殊的函数,最暴力的调用,无视堆栈
	unsigned int invokeAnycall(void* ecx, void* edx, void* address, void* a1 = 0, void* a2 = 0, void* a3 = 0, void* a4 = 0, void* a5 = 0, void* a6 = 0, void* a7 = 0,
		void* a8 = 0, void* a9 = 0, void* a10 = 0, void* a11 = 0, void* a12 = 0, void* a13 = 0, void* a14 = 0, void* a15 = 0);
}