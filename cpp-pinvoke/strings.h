#pragma once

#include <wtypes.h>
#include <stdio.h>
#include <OleAuto.h>

extern "C" {
	__declspec(dllexport) BSTR getHelloString();

}

BSTR ANSItoBSTR(const char* input);