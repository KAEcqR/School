#include <iostream>

using namespace std;

class Komputer {
protected:
	string marka;
	string model;
public: 
	Komputer() {};
	Komputer(string marka, string model) {
		this->marka = marka;
		this->model = model;
	}

	string Info() {
		return "Marka:" + marka + " Model: " + model;
	}
};

class Laptop : Komputer {
protected: 
	string ekran;
	string kolor;
public: 
	Laptop() {};
	Laptop(string marka, string model, string ekran, string kolor) : Komputer(marka, model) {
		this->marka = marka;
		this->model = model;
		this->kolor = kolor;
		this->ekran = ekran;
	}

	void Wprowadz() {
		cout << "Podaj marke" << endl;
		cin >> marka;
		cout << "Podaj model" << endl;
		cin >> model;
		cout << "Podaj przekatna ekranu" << endl;
		cin >> ekran;
		cout << "Podaj kolor obudowy" << endl;
		cin >> kolor;
	}

	string Info() {
		return Komputer::Info() + " Ekran: " + ekran + " Kolor: " + kolor;
	}
};

class PC : Komputer {
protected:
	string obudowa;
public:
	PC() {};
	PC(string marka, string model, string obudowa) : Komputer(marka, model) {
		this->marka = marka;
		this->model = model;
		this->obudowa = obudowa;
	}

	void Wprowadz() {
		cout << "Podaj marke" << endl;
		cin >> marka;
		cout << "Podaj model" << endl;
		cin >> model;
		cout << "Podaj rodzaj obudowy" << endl;
		cin >> obudowa;
	}

	string Info() {
		return Komputer::Info() + " Obudowa: " + obudowa;
	}
};

int main()
{
	Laptop macbook;
	macbook.Wprowadz();
	cout << macbook.Info();
}