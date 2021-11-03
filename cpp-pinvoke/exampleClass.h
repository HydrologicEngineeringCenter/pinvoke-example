#pragma once

#include "strings.h"

class ExampleClass {
	public:
		int num;
		char* word;
		int* nums;
		int nums_length;
		ExampleClass(int num, char* string, int* nums, int nums_length);

	private:
		void initializeNum(int num);
		void initializeWord(char* word);
		void initializeNums(int* nums, int nums_length);
};

extern "C" {
	__declspec(dllexport) ExampleClass* createExampleClass(int num, char* word, int* nums, int nums_length);
	__declspec(dllexport) int getNum(ExampleClass* ec);
	__declspec(dllexport) BSTR getWord(ExampleClass* ec);
	__declspec(dllexport) int* getNums(ExampleClass* ec);
	__declspec(dllexport) int getNumsLength(ExampleClass* ec);
}