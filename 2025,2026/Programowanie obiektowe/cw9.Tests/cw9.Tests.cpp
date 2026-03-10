#define UNIT_TEST
#include "pch.h"
#include "../cw9/cw9.cpp"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace cw9Tests
{
	TEST_CLASS(cw9Tests)
	{
	public:
		
		TEST_METHOD(NWD_podstawowy)
		{
			Assert::AreEqual(5, NWD::rekurencja(35, 75));
		}

		TEST_METHOD(NWD_wielokrotnosc)
		{
			Assert::AreEqual(5, NWD::rekurencja(5, 25));
		}
	};
}
