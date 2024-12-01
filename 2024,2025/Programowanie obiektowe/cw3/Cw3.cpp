#include <iostream>

using namespace std;

class Book {
	string Title;
	string Author;
	int* Rates;
	int RatesCounter;
public : 
	Book(string title, string author) {
		Title = title;
		Author = author;

		RatesCounter = 2; 
		Rates = new int[RatesCounter];
		Rates[0] = 4;
		Rates[1] = 5;
	}

	Book(const Book& original) {
		Title = original.Title;
		Author = original.Author;
		RatesCounter = original.RatesCounter;

		Rates = new int[RatesCounter];
		for (int i = 0; i < RatesCounter; i++) {
			Rates[i] = original.Rates[i];
		}
	}

	void setRate(int field, int rate) {
		Rates[field] = rate; 
	}

	void Info() {
		cout << "Tytuł: " << Title << " - " << Author << endl;
		cout << "Ocena: " << (Rates[0] + Rates[1]) / 2 << endl;
	}

	~Book() {
		delete[] Rates;
		Rates = nullptr;
	}
};

int main(){
	Book book1("Pan Tadeusz", "Adam Mickiewicz");
	Book book2("Opus magnum C++", "Jerzy Grebosz");
	Book book3 = book2;

	book2.setRate(1, 6);

	book1.Info();
	book2.Info();

	book3.Info();
	book2.setRate(0, 1);
}
