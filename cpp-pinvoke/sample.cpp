#include "pch.h"
#include "sample.h"


BSTR ReturnHello() {
	return ::SysAllocString(L"Hello!");
}