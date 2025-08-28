#include <iostream>
#include <string>

using namespace std;

struct Data {
    int dzien;
    int miesiac;
    int rok;
};

class Samochod {
private:
    string marka;
    string model;
    int rokProd;
    double cena;
    string numerRej;
    Data dataPierwszejRej;

public:
    Samochod() {
        cout << "Tworzony jest obiekt Samochod." << endl;
    }

    Samochod(const string& m, const string& mod, int rp, double c, const string& nr, Data dpr)
        : marka(m), model(mod), rokProd(rp), cena(c), numerRej(nr), dataPierwszejRej(dpr) {}

    void wyswietlDane() {
        cout << "Marka: " << marka << endl;
        cout << "Model: " << model << endl;
        cout << "Rok produkcji: " << rokProd << endl;
        cout << "Cena: " << cena << " PLN" << endl;
        cout << "Numer rejestracyjny: " << numerRej << endl;
        cout << "Data pierwszej rejestracji: "
            << dataPierwszejRej.dzien << "-"
            << dataPierwszejRej.miesiac << "-"
            << dataPierwszejRej.rok << endl;
    }

    void ustawDane(const string& m, const string& mod, int rp, double c, const string& nr, Data dpr) {
        marka = m;
        model = mod;
        rokProd = rp;
        cena = c;
        numerRej = nr;
        dataPierwszejRej = dpr;
    }
};

int main() {
    string marka, model, numerRej;
    int rokProd;
    double cena;
    Data dataRej;

    cout << "Podaj markę samochodu: ";
    cin >> marka;
    cout << "Podaj model samochodu: ";
    cin >> model;
    cout << "Podaj rok produkcji: ";
    cin >> rokProd;
    cout << "Podaj cenę (w PLN): ";
    cin >> cena;
    cout << "Podaj numer rejestracyjny: ";
    cin >> numerRej;
    cout << "Podaj datę pierwszej rejestracji (dzien miesiac rok): ";
    cin >> dataRej.dzien >> dataRej.miesiac >> dataRej.rok;

    Samochod samochod(marka, model, rokProd, cena, numerRej, dataRej);

    cout << "\nDane samochodu:" << endl;
    samochod.wyswietlDane();

    return 0;
}
