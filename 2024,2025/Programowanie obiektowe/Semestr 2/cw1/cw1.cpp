#include <iostream>

using namespace std;

class Pracownik {
protected:
    string imie, nazwisko;
public:
    Pracownik(string imie, string nazwisko) : imie{ imie }, nazwisko{ nazwisko } {};
    virtual void zwrocDane();
};

class Nauczyciel : public Pracownik {
protected:
    string przedmiot;
public:
    Nauczyciel(string imie, string nazwisko, string przedmiot) : Pracownik(imie, nazwisko) {
        this->przedmiot = przedmiot;
    }
    void zwrocDane();
};

class Wychowawca : public Nauczyciel {
    string klasa;
public:
    Wychowawca(string imie, string nazwisko, string przedmiot, string klasa) : Nauczyciel(imie, nazwisko, przedmiot) {
        this->klasa = klasa;
    }
    void zwrocDane();
};

void Pracownik::zwrocDane() {
    cout << "Metoda zwrocDane z klasy Pracownik " << endl;
    cout << "Imie: " << imie << endl;
    cout << "Nazwisko: " << nazwisko << endl;
}

void Nauczyciel::zwrocDane() {
    cout << "Metoda zwrocDane z klasy Nauczyciel " << endl;
    cout << "Imie: " << imie << endl;
    cout << "Nazwisko: " << nazwisko << endl;
    cout << "Przedmiot: " << przedmiot << endl;
}

void Wychowawca::zwrocDane() {
    cout << "Metoda zwrocDane z klasy Wychowawca " << endl;
    cout << "Imie: " << imie << endl;
    cout << "Nazwisko: " << nazwisko << endl;
    cout << "Przedmiot: " << przedmiot << endl;
    cout << "Klasa: " << klasa << endl;
}

int main()
{
    Pracownik* w_pracownik;

    Pracownik pracownik1("Tomek", "Atomek");
    Nauczyciel pracownik2("Anna", "Kowalska", "Matematyka");
    Wychowawca pracownik3("Daria", "Nowak", "Fizyka", "4c");

    //w_pracownik = &pracownik1;
    //w_pracownik->zwrocDane();

    //w_pracownik = &pracownik2;
    //w_pracownik->zwrocDane();

    //w_pracownik = &pracownik3;
    //w_pracownik->zwrocDane();

    Pracownik* pracownicy[] = { &pracownik1, &pracownik2, &pracownik3 };

    for (Pracownik* pracownik : pracownicy) {
		pracownik->zwrocDane();
	}
}

