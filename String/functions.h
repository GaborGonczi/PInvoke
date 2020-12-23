#pragma once
#include<string.h>
#ifdef __cplusplus
extern "C" {
#endif
	
	struct __declspec(dllexport) Obj
	{
		char*field;
	};
	__declspec(dllexport) Obj*create();
	__declspec(dllexport) void set(const char* str, Obj*my);
	__declspec(dllexport) char*get(Obj*my);
	__declspec(dllexport) void deleteobj(Obj*my);


#ifdef __cplusplus
}
#endif

