#include "pch.h"
#include "exampleClass.h"
#include <string.h>
#include <algorithm>
#include <iterator>

ExampleClass::ExampleClass(int num, char* word, int* nums, int nums_length) {
	initializeNum(num);
	initializeWord(word);
	initializeNums(nums, nums_length);
}

ExampleClass::~ExampleClass()
{
	if (this->word)
		free(this->word);
	if (this->nums) {
		free(this->nums);
	}
	free(this);
}

void ExampleClass::initializeNum(int num)
{
	this->num = num;
}

void ExampleClass::initializeWord(char* word)
{
	this->word = (char*)malloc(strlen(word) + 1);
	if (this->word != NULL) {
		this->word = _strdup(word);
	}
}

void ExampleClass::initializeNums(int* nums, int nums_length)
{
	if (nums != NULL) {
		this->nums = (int*)malloc(nums_length * sizeof(INT));
		if (this->nums != NULL) {
			std::copy(nums, nums + nums_length, this->nums);
			this->nums_length = nums_length;
		}
	}
	else {
		this->nums = NULL;
		this->nums_length = 0;
	}
}

extern "C" ExampleClass* createExampleClass(int num, char* word, int* nums, int nums_length) {
	return new ExampleClass(num, word, nums, nums_length);
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

extern "C" int getNumsLength(ExampleClass * ec)
{
	return ec->nums_length;
}
