#include <iostream>

using namespace std;

int binarysearch(int t[], int n, int liczba) {
	int poczatek = 0;
	int koniec = n - 1;
	int srodek = (poczatek + koniec) / 2;
	int wynik;

	while (poczatek <= koniec) {
		if (t[srodek] < liczba) {
			poczatek = srodek + 1;
		}
		else {
			if (t[srodek] == liczba) {
				wynik = srodek;
				break;
			}
			else {
				koniec = srodek - 1;
			}
		}
		srodek = (poczatek + koniec) / 2;
	}
	if (poczatek > koniec) wynik = -1;

	return wynik;
}

int binarysearchR(int t[], int liczba, int poczatek, int koniec) {
	if (poczatek > koniec) return -1;
	int srodek = (poczatek + koniec) / 2;
	if (t[srodek] == liczba) return srodek;

	if (t[srodek] < liczba) {
		poczatek = srodek + 1;
	}
	else {
		koniec = srodek - 1;
	}

	return binarysearchR(t, liczba, poczatek, koniec);
}

int main()
{

	int liczby[]{ 10,21,32,43,54,65,76,87,98,109 };
	int n = sizeof(liczby) / sizeof(int);

	cout << binarysearch(liczby, n, 87) << endl;
}
