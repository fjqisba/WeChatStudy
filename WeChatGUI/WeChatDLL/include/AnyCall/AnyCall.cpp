#pragma once

namespace AnyCall
{
	unsigned int __declspec(naked) invokeAnycall(void* pEcx, void* pEdx, void* address, void* a1 /*= 0*/, void* a2 /*= 0*/, void* a3 /*= 0*/, void* a4 /*= 0*/, void* a5 /*= 0*/, void* a6 /*= 0*/, void* a7 /*= 0*/, void* a8 /*= 0*/, void* a9 /*= 0*/, void* a10 /*= 0*/, void* a11 /*= 0*/, void* a12 /*= 0*/, void* a13 /*= 0*/, void* a14 /*= 0*/, void* a15 /*= 0*/)
	{
		__asm
		{
			push ebp;
			mov ebp, esp;
			mov ecx, pEcx;
			mov edx, pEdx;
			push a15;
			push a14;
			push a13;
			push a12;
			push a11;
			push a10;
			push a9;
			push a8;
			push a7;
			push a6;
			push a5;
			push a4;
			push a3;
			push a2;
			push a1;
			call address;
			mov esp, ebp;
			pop ebp;
			ret;
		}
	}
}