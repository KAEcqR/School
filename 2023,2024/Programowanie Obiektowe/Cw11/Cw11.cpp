#include <iostream>

using namespace std;

int main()
{
    int wynik = 0;
    int tablica[5]{};
    int max = 0; 
    int min = 0;
    for (int i = 0; i <= 5 - 1; i++) {
        cout << "Podaj liczbe ";
        cin >> tablica[i];
        wynik += tablica[i];
    }
    cout << "twoja tablica to: \n";

    for (int i : tablica) {
        cout << i << ", ";
        if (tablica[i] > max) {
            max == tablica[1];
        }
        if (tablica[i] < min) {
            max == tablica[1];
        }
        i++;
    }
    cout << "\nsuma elementow tablicy to " << wynik;
    cout << "\nsrednia elementow tablicy to " << wynik / 5;
    cout << "\nmaksymalny element tablicy to " << max;
    cout << "\nminimalny element tablicy to " << min;
}
