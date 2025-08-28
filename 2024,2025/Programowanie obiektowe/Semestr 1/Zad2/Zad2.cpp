#include <iostream>

using namespace std;

class Prostopadloscian {
public:
    double dl;
    double sz;
    double wys;

    Prostopadloscian() : dl(1.0), sz(1.0), wys(1.0) {}

    Prostopadloscian(double dlugosc, double szerokosc, double wysokosc) : dl(dlugosc), sz(szerokosc), wys(wysokosc) {}

    double obliczObjetosc() {
        return dl * sz * wys;
    }

    double obliczPoleBoczne() {
        return 2 * (dl * wys + sz * wys);
    }

    double obliczCalkowitaDlugoscKrawedzi() {
        return 4 * (dl + sz + wys);
    }
};

int main() {
    Prostopadloscian p1;
    cout << "Domyślny prostopadłościan:" << endl;
    cout << "Objętość: " << p1.obliczObjetosc() << endl;
    cout << "Długość wszystkich krawędzi: " << p1.obliczCalkowitaDlugoscKrawedzi() << endl;
    cout << "Pole powierzchni bocznej: " << p1.obliczPoleBoczne() << endl;

    double dlugosc, szerokosc, wysokosc;
    cout << "\nPodaj długość prostopadłościanu: "; cin >> dlugosc;
    cout << "Podaj szerokość prostopadłościanu: "; cin >> szerokosc;
    cout << "Podaj wysokość prostopadłościanu: "; cin >> wysokosc;

    Prostopadloscian p2(dlugosc, szerokosc, wysokosc);
    cout << "\nProstopadłościan z wprowadzonymi parametrami:" << endl;
    cout << "Objętość: " << p2.obliczObjetosc() << endl;
    cout << "Długość wszystkich krawędzi: " << p2.obliczCalkowitaDlugoscKrawedzi() << endl;
    cout << "Pole powierzchni bocznej: " << p2.obliczPoleBoczne() << endl;
}
