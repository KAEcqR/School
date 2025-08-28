#include <iostream>

using namespace std;

class Samochod {
protected :
	string marka;
	string model;
	int rok_produkcji;

public:
	Samochod(string marka, string model, int rok_produkcji) {
		this->marka = marka;
		this->model = model;
		this->rok_produkcji = rok_produkcji;
	}

	Samochod() {

	}

	void WprowadzDane() {
		cout << "Podaj marke : ";
		cin >> marka;
		cout << "Podaj model : ";
		cin >> model;
		cout << "podaj rok_produkcji : ";
		cin >> rok_produkcji;
		cout << "-------------------------" << endl;
		cout << "Marka : " << marka << endl;
		cout << "Model : " << model << endl;
		cout << "Rok produkcji : " << rok_produkcji << endl;
		cout << "-------------------------" << endl;
	}
};

class Ciezarowy : public Samochod {
protected: 
	string przeznaczenie;
	int wybor = 0;

public:
	Ciezarowy(string marka, string model, int rok_produkcji, string przeznaczenie) {
		this->marka = marka;
		this->model = model;
		this->rok_produkcji = rok_produkcji;
		this->przeznaczenie;
	}

	Ciezarowy() {

	}

	void WprowadzDane() {
		cout << "Podaj marke : ";
		cin >> marka;
		cout << "Podaj model : ";
		cin >> model;
		cout << "podaj rok_produkcji : ";
		cin >> rok_produkcji;
		cout << "(1) wywrotka" << endl; 
		cout << "(2) chlodnia" << endl;
		cout << "(3) cysterna" << endl;
		cout << "podaj przeznaczenie : ";
		cin >> wybor;
		if (wybor == 1 ){
			przeznaczenie = "wywrotka";
		} else if(wybor == 2) {
			przeznaczenie = "chlodnia";
		} else if (wybor == 3) {
			przeznaczenie = "cysterna";
		} else {
			cout << "Blad, wprowadz dane jeszcze raz" << endl;
			WprowadzDane();
		}
	
		cout << "-------------------------" << endl;
		cout << "Marka : " << marka << endl;
		cout << "Model : " << model << endl;
		cout << "Rok produkcji : " << rok_produkcji << endl;
		cout << "Przeznaczenie : " << przeznaczenie << endl;
		cout << "-------------------------" << endl;
	}
};

class Autobus : public Samochod{
protected:
	int liczba_miejsc_stojacych;
	int liczba_miejsc_siedzacych;
public :
	Autobus(string marka, string model, int rok_produkcji, int liczba_miejsc_stojacych, int liczba_miejsc_siedzacych) : Samochod(marka, model, rok_produkcji) {
		this->liczba_miejsc_stojacych = liczba_miejsc_stojacych;
		this->liczba_miejsc_siedzacych = liczba_miejsc_siedzacych;
	}

	Autobus() {

	}

	void WyswietlDane() {
		cout << "Marka : " << marka << endl;
		cout << "Model : " << model << endl;
		cout << "Rok produkcji : " << rok_produkcji << endl;
		cout << "Liczba miejsc stojacych : " << liczba_miejsc_stojacych << endl;
		cout << "Liczba miejsc siedzacych : " << liczba_miejsc_siedzacych << endl;
	}

	void WprowadzDane() {
		cout << "Podaj marke : ";
		cin >> marka;
		cout << "Podaj model : ";
		cin >> model;
		cout << "podaj rok_produkcji : ";
		cin >> rok_produkcji;
		cout << "podaj liczbe miejsc siedzacych : ";
		cin >> liczba_miejsc_siedzacych;
		cout << "podaj liczbe miejsc stojacych : ";
		cin >> liczba_miejsc_stojacych;
		cout << "-------------------------" << endl;
		cout << "Marka : " << marka << endl;
		cout << "Model : " << model << endl;
		cout << "Rok produkcji : " << rok_produkcji << endl;
		cout << "Liczba miejsc stojacych : " << liczba_miejsc_stojacych << endl;
		cout << "Liczba miejsc siedzacych : " << liczba_miejsc_siedzacych << endl;
		cout << "-------------------------" << endl;
	}
};

int main()
{
	Ciezarowy ciezarowka("marka","model",1920,"wywrotka");
	ciezarowka.WprowadzDane();

	Autobus autobusik("marka", "model", 2014, 50, 20);
	autobusik.WyswietlDane();
}
