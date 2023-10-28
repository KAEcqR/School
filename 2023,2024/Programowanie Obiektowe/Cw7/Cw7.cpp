#include <iostream>

using namespace std;

int main(){
	
	enum Stanowisko {
		dyrektor,
		kierownik,
		sekretarka,
		portier
	} stanowisko = dyrektor;
	
	enum Ocena {
		niedostateczny = 1,
		dopuszczajacy = 2,
		dostateczny = 3,
		dobry = 4,
		bardzo_dobry = 5,
		celujacy = 6
	} Ocena = niedostateczny;

	Stanowisko stanowisko2 = sekretarka;

	std::cout << stanowisko << std::endl;
	std::cout << stanowisko2 << std::endl;

	std::cout << Ocena << std::endl;

	switch (Ocena) {
		case niedostateczny: {
			cout << "niedostateczny";
			break;
		}
		case dostateczny: {
			cout << "dostateczny";
			break;
		}
		case dopuszczajacy: {
			cout << "dopuszczajacy";
			break;
		}
		case dobry: {
			cout << "dobry";
			break;
		}
		case bardzo_dobry: {
			cout << "bardzo_dobry";
			break;
		}
		case celujacy: {
			cout << "celujacy";
			break;
		}
	}

};