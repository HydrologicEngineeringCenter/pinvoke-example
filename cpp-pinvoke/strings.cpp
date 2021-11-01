#include "pch.h"
#include "strings.h"

extern "C" BSTR getHelloString() {
	const char* s = "Hello";
    BSTR bstr = ANSItoBSTR(s);
	return bstr;
}

BSTR ANSItoBSTR(const char* input) {
    BSTR result = NULL;
    int lenA = lstrlenA(input);
    int lenW = ::MultiByteToWideChar(CP_ACP, 0, input, lenA, NULL, 0);
    if (lenW > 0)
    {
        result = ::SysAllocStringLen(0, lenW);
        ::MultiByteToWideChar(CP_ACP, 0, input, lenA, result, lenW);
    }
    return result;
}