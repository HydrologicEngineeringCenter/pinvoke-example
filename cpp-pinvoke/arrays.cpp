#include "pch.h"
#include "arrays.h"

int fillArrayWithVals(int* arr, int length)
{
	for (size_t i = 0; i < length; i++)
	{
		arr[i] = i;
	}

	return 0;
}
