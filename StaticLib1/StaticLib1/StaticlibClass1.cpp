#include "pch.h"
#include "StaticlibClass1.h"

// TEST
#include <stdexcept>

using namespace std;

namespace MathFuncs
{
	double StaticlibClass1::Add(double a, double b)
	{
		return a + b;
	}

	double StaticlibClass1::Subtract(double a, double b)
	{
		return a - b;
	}

	double StaticlibClass1::Multiply(double a, double b)
	{
		return a * b;
	}

	double StaticlibClass1::Divide(double a, double b)
	{
		return a / b;
	}
}