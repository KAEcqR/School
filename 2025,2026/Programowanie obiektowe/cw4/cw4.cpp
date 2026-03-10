#include <iostream>
#include<cmath>

using namespace std;

template<typename T>
T Max(T a, T b) {
	if (a > b) return a;
	else return b;
}

template<>
float Max(float a, float b) {
	float tempA = round(a * 10) / 10;
	float tempB = round(b * 10) / 10;

	if (tempA > tempB) return tempA;
	else return tempB;
}

int main()
{
	cout << Max(5, 9) << "\n";
	cout << Max<char>('g', 'b') << "\n";
	cout << Max<float>(4.789, 5.91) << "\n";
}