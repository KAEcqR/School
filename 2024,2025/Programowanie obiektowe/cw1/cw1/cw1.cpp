// cw1.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
#include <string>

using namespace std;

struct Data {
	int dd, mm, rr;
};

class Pracownik {
public:
	string imie, nazwisko;
	Data data_urodzenia;
	int wiek;
	Data data_zatrudnienia;

	/*Pracownik() {
		imie = "Gall";
		nazwisko = "Anonim";
		wiek = 1000; 
		data_urodzenia = { 1,1,1024 };
	}*/

	Pracownik(string imie="Tomek", string nazwisko="Atomek", int wiek = 24) {
		this->imie = imie;
		this->nazwisko = nazwisko;
		this->wiek = wiek;
		data_urodzenia = { 1,1,2000};
		data_zatrudnienia = { 1,1,2024 };
	}

	Pracownik(string imie, string nazwisko, int wiek, Data data_urodzenia) {
		this->imie = imie;
		this->nazwisko = nazwisko;
		this->wiek = wiek;
		this->data_urodzenia = data_urodzenia;
		this->data_zatrudnienia = { 1, 1, 2024 };
	}

	Pracownik(string imie, string nazwisko, int wiek, Data data_urodzenia, Data data_zatrudnienia) {
		this->imie = imie;
		this->nazwisko = nazwisko;
		this->wiek = wiek; 
		this->data_urodzenia = data_urodzenia; 
		this->data_zatrudnienia = data_zatrudnienia;
	}



	void WyswietlDane() {
		cout << "Imie: " << imie << endl;
		cout << "Nazwisko: " << nazwisko << endl;
		cout << "Wiek: " << wiek << endl;
		cout << "Data zatrudnienia: " << data_zatrudnienia.dd << "-" << data_zatrudnienia.mm << "-" << data_zatrudnienia.rr << endl;
		cout << "Data urodzenia: " << data_urodzenia.dd << "-" << data_urodzenia.mm << "-" << data_urodzenia.rr << endl;
	}
};

int main() {
	Pracownik Pracownik1;
	Pracownik1.WyswietlDane();

	Pracownik pracownik2("Anna", "Kowalska", 24);
	pracownik2.WyswietlDane();

	Pracownik pracownik3("Anna", "Kowalska", 24, { 1,2,2001 });
	pracownik3.WyswietlDane();

	Pracownik pracownik4("Maryla", "Rodowicz", 1203, { 10,2,821 } , { 1,12, 824 });
	pracownik4.WyswietlDane();
}

Pracownik::Pracownik(string imie, string nazwisko, int wiek, Data data_urodzenia, Data data_zatrudnienia) :
	imie{ imie },
	nazwisko{ nazwisko },
	wiek{ wiek },
	data_urodzenia{ data_urodzenia },
	data_zatrudnienia{ data_zatrudnienia }
	{
	cout << "dziala" << endl;
	}