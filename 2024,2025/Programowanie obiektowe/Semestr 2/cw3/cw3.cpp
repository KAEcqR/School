#include <iostream>

using namespace std;

class Osoba {
public: 
	string imie, nazwisko;

	void metoda() {
		cout << "Jestem klasa abstrakcyjna" << endl;
	}

	virtual void wyswietlDane() = 0;
};

class Pracownik : public Osoba {
public :
	string stanowisko;

	void wyswietlDane() {
		cout << imie << " " << nazwisko << " " << stanowisko << endl;
	}

	Pracownik(string imie, string nazwisko, string stanowisko) {
		this->imie = imie;
		this->nazwisko = nazwisko;
		this->stanowisko = stanowisko;
	}
};

int main()
{

}
