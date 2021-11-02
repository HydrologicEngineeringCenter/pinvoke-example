#include "pch.h"
#include "exampleClass.h"
#include <string.h>

ExampleClass::ExampleClass(int num, char* word, int* nums) {
	this->num = num;
	this->nums = nums;

	this->word = (char*)malloc(strlen(word) + 1);
	if (this->word != NULL) {
		this->word = _strdup(word);
	}
}

extern "C" ExampleClass* createExampleClass(int num, char* word, int* nums) {
	return new ExampleClass(num, word, nums);
}

extern "C" int getNum(ExampleClass * ec) {
	return ec->num;
}

extern "C" BSTR getWord(ExampleClass * ec) {
	return ANSItoBSTR((const char*)ec->word);
}

extern "C" int* getNums(ExampleClass * ec) {
	return ec->nums;
}