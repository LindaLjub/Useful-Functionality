// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "StaticlibClass1.h"



using namespace std;

int main()
{
	double a = 7.4;
	int b = 99;

	cout << "a + b = " <<
		MathFuncs::StaticlibClass1::Add(a, b) << endl;
	cout << "a - b = " <<
		MathFuncs::StaticlibClass1::Subtract(a, b) << endl;
	cout << "a * b = " <<
		MathFuncs::StaticlibClass1::Multiply(a, b) << endl;
	cout << "a / b = " <<
		MathFuncs::StaticlibClass1::Divide(a, b) << endl;

	return 0;
}