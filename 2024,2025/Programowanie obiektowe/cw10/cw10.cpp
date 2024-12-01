#include <iostream>
using namespace std;

class Pracownik {
public:
	string imie;
	string nazwisko;
	string stanowisko;
	Pracownik(string imie, string nazwisko, string stanowisko) {
		this->imie = imie;
		this->nazwisko = nazwisko;
		this->stanowisko = stanowisko;
	}

	string zwrocDane();
	void zwrocDane(string&, string&, string&);
};

int main()
{
	Pracownik pracownik1("Tomek", "Atomek", "dyrektor");
	Pracownik pracownik2("Anna", "Kowalska", "kierownik");
	cout << pracownik1.zwrocDane() << endl;

	string imie, nazwisko, stanowisko;
	pracownik2.zwrocDane(imie, nazwisko, stanowisko);
	cout << imie << " " << nazwisko << " " << stanowisko << endl;
}

string Pracownik::zwrocDane() {
	return imie + " " + nazwisko + " " + stanowisko;
}

void Pracownik::zwrocDane(string& pImie, string& pNazwisko, string& pStanowisko) {
	this->imie = imie;
	this->nazwisko = nazwisko;
	this->stanowisko = stanowisko;
};