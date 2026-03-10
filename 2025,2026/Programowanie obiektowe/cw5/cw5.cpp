#include <iostream>

using namespace std;

int main()
{
    try {
        double licznik = 1, mianownik = 0;
        if (mianownik == 0) throw mianownik;

        cout << "licznik: " << licznik << endl;
        cout << "mianownik: " << mianownik << endl;
        cout << "iloraz: " << licznik / mianownik << endl;
    }
    catch (double blad) {
        cout << "Blad dzielenia przez " << blad << endl;
    }
}
