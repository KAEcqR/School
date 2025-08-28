#include <iostream>

using namespace std;

class Konto {
	int stan;

public:
	Konto() {
		stan = 100;
	}

	int podajStan() {
		return stan;
	}

	void wplac(int kwota) {
		stan += kwota;
	}

	bool wyplac(int kwota) {
		if (kwota > stan) {
			return false;
		}
		else {
			stan -= kwota;
			return true;
		}
	}

	int zamknij() {
		int stanPrev = stan;
		stan = 0;
		return stanPrev;
	}

	int podatek(int odsetki) {
		int podatek = odsetki * (0, 19);
		stan -= podatek;
		return podatek;
	}
};

int main()
{
	
}