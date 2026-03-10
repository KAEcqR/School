#include <iostream>

using namespace std;

template<class T, int n>
class Oceny {
public:
	T oceny[n];
	T max() {
		T temp = oceny[0];
		for (int i = 1; i < n; i++)
		{
			if (oceny[i] > temp) temp = oceny[i];
		}
		return temp;
	};
	T min() {
		T temp = oceny[0];
		for (int i = 1; i < n; i++)
		{
			if (oceny[i] < temp) temp = oceny[i];
		}
		return temp;
	};
	T srednia() {
		T temp = 0;
		for (int i = 1; i < n; i++)
		{
			temp += oceny[i];
		}
		return temp / n;
	};
};

int main()
{
	Oceny<float, 4> oceny{ 3,4,2,5 };
	cout << "najwyzsza ocena" << oceny.max();
	cout << "najnizsza ocena" << oceny.min();
	cout << "srednia z ocen" << oceny.srednia();
}
