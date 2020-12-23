#include "BasicOperation.h"
#include <iostream>

int addition(int num1, int num2)
{
	return num1 + num2;
}

int substraction(int num1, int num2)
{
	return num1-num2;
}

int multiplication(int num1, int num2)
{
	return num1*num2;
}

double division(int num1, int num2)
{
	if (num2 == 0) {
		std::cout << "0-aval tilos osztani\n";
	}
	else
	{
		return num1 / num2;
	}
}
