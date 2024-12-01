#include <iostream>

using namespace std;

class Wielokat {
private:
    int* boki;
    int iloscBokow;

    void dodajBoki() {
        for (int i = 0; i < iloscBokow; ++i) {
            cout << "Podaj dlugosc boku " << char(97 + i) << ": ";
            cin >> boki[i];
        }
    }

public: 
    Wielokat() : iloscBokow(4) {
        boki = new int[iloscBokow] {2, 2, 2, 2}; 
    }
        
    Wielokat(int iloscBokow) : iloscBokow(iloscBokow) {
        boki = new int[iloscBokow];
        dodajBoki();
    }

    Wielokat(const Wielokat& pierwszy) : iloscBokow(pierwszy.iloscBokow) {
        boki = new int[iloscBokow];
        for (int i = 0; i < iloscBokow; ++i) {
            boki[i] = pierwszy.boki[i] * 2; 
        }
    }

    void Info() {
        for (int i = 0; i < iloscBokow; ++i) {
            cout << "Bok " << char(97 + i) << " = " << boki[i] << endl;
        }
    }

    int Obwod() {
        int obwod = 0;
        for (int i = 0; i < iloscBokow; ++i) {
            obwod += boki[i];
        }
        return obwod;
    }

};

int main()
{
    Wielokat w1;
    w1.Info();
    cout << "Obwod: " << w1.Obwod() << endl;
    Wielokat w2(5);
    w2.Info();
    cout << "Obwod: " << w2.Obwod() << endl;
    Wielokat w3(w2);
    w3.Info();
    cout << "Obwod: " << w3.Obwod() << endl;
}
