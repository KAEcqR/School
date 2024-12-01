#include <iostream>

using namespace std;

class Pracownik {
public:
	string imie, naziwsko;
	void zwrocDane();
};

class Nauczyciel : public Pracownik {
public:
	string przedmiot;
	void zwrocDane();
};

class Wychowawca : public Nauczyciel {
public:
	string klasa;
	void zwrocDane();
};


int main()
{
	Pracownik* w_pracownik;

	Pracownik pracownik1;
	w_pracownik = &pracownik1;

	w_pracownik->imie = "Anna";
}
