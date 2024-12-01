#include <iostream>
#include <string>

using namespace std;

class PrzeliczDlugosc {
public:
    double wartosc;
    string jednostka;

    PrzeliczDlugosc(double w, string j) : PrzeliczDlugosc() {
        wartosc = w;
        jednostka = j;
    }

    PrzeliczDlugosc() {
        cout << "Docelową jednostką miary jest metr." << endl;
    }


    double naMetry() {
        if (jednostka == "cale") return wartosc * 0.0254;
        if (jednostka == "jardy") return wartosc * 0.9144;
        if (jednostka == "stopy") return wartosc * 0.3048;
        if (jednostka == "mile") return wartosc * 1609.34;

        cerr << "Nieznana jednostka: " << jednostka << endl;
        return -1;
    }
};

int main() {
    double dlugosc;
    string jednostka;

    cout << "Podaj długość: ";
    cin >> dlugosc;
    cout << "Podaj jednostkę (cale, stopy, jardy, mile): ";
    cin >> jednostka;

    PrzeliczDlugosc przeliczenie(dlugosc, jednostka);

    double wynik = przeliczenie.naMetry();
    if (wynik != -1) {
        cout << "Długość w metrach: " << wynik << " m" << endl;
    }

}
