#pragma once

#include "strings.h"

class ExampleClass {
	public:
		int num;
		char* word;
		int* nums;
		ExampleClass(int num, char* string, int* nums);
};

extern "C" {
	__declspec(dllexport) ExampleClass* createExampleClass(int num, char* word, int* nums);
	__declspec(dllexport) int getNum(ExampleClass* ec);
	__declspec(dllexport) BSTR getWord(ExampleClass* ec);
	__declspec(dllexport) int* getNums(ExampleClass* ec);
}