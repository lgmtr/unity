#include <iostream>
#include <string>
#include <sstream>

#define DLLExport __declspec (dllexport)

extern "C" {

	char* MakeStringCopy(const char* string) {
		if (string == NULL) return NULL;
		char* res = (char*)malloc(strlen(string) + 1);
		strcpy_s(res, sizeof res,string);
		return res;
	}

	DLLExport int GetRandomX() {
		return rand();
	}

	DLLExport int GetRandomY() {
		return rand();
	}

	DLLExport int GetRandomZ() {
		return rand();
	}

	DLLExport char* EchoString(char* some) {
		return some;
	}
}