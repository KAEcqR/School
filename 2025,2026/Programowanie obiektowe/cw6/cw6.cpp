#include <iostream>
#include <string>

using namespace std;

bool wejscieFormat(string sDana) {
	for (int i = 0; i < sDana.length(); i++)
	{
		if (isdigit(sDana[i]) == false) {
			return false;
		}
	}
	return true;
}

bool wejscieZakres(int iDana) {
	if ((iDana >= 1) && (iDana <= 6)) return true;
	else return false;
}

int main()
{
	string ocena = "10";

	try {
		if (wejscieFormat(ocena) == false) {
			throw ocena;
		}

		int iOcena = stoi(ocena);

		if (wejscieZakres(iOcena) == false) {
			throw iOcena;
		}

		switch (iOcena) {
		case 1:
			cout << "Uczen dostal 1" << endl;
			break;

		case 6:
			cout << "Uczen dostal 6" << endl;
			break;
		}
	}
	catch (string) {
		cout << "ocena jest stringiem" << endl;
	}
	
	catch (int) {
		cout << "zly zakres wartosci" << endl;
	}
}
