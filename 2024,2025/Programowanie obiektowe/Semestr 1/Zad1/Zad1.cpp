#include <iostream>
#include <string>

using namespace std;

class Uczen {
public:
    int klasa;
    int numerDziennika;
    int grupa;
    string imie;
    string nazwisko;

    Uczen(string im, string nz, int kl, int gr, int nd) : imie(im), nazwisko(nz), klasa(kl), grupa(gr), numerDziennika(nd) {}

    Uczen() : imie("N/A"), nazwisko("N/A"), klasa(0), grupa(0), numerDziennika(0) {}

    void wyswietlDane() {
        cout << "Imię: " << imie << endl
            << "Nazwisko: " << nazwisko << endl
            << "Klasa: " << klasa << endl
            << "Grupa: " << grupa << endl
            << "Numer w dzienniku: " << numerDziennika << endl;
    }
};

int main() {
    Uczen uczenDomyslny;
    cout << "Dane ucznia (domyślne):" << endl;
    uczenDomyslny.wyswietlDane();

    string imie, nazwisko;
    int klasa, grupa, numerDziennika;

    cout << "\nWprowadź dane ucznia:" << endl;
    cout << "Imię: "; cin >> imie;
    cout << "Nazwisko: "; cin >> nazwisko;
    cout << "Klasa: "; cin >> klasa;
    cout << "Grupa: "; cin >> grupa;
    cout << "Numer w dzienniku: "; cin >> numerDziennika;

    Uczen uczen(imie, nazwisko, klasa, grupa, numerDziennika);

    cout << "\nDane ucznia (wprowadzone):" << endl;
    uczen.wyswietlDane();

    return 0;
}
