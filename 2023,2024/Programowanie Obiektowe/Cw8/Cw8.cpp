#include <iostream>

using namespace std;

int main()
{
    int Jpolski, matematyka, Jangielski, chemia;
    int* przedmiot = nullptr;

    przedmiot = &Jpolski;
    cout << "Podaj ocene z polskiego: ";
    cin >> *przedmiot;
    
    przedmiot = &matematyka;
    cout << "Podaj ocene z matematyki: ";
    cin >> matematyka;

    przedmiot = &Jangielski;
    cout << "Podaj ocene z angielskiego: ";
    cin >> Jangielski;

    przedmiot = &chemia;
    cout << "Podaj ocene z chemi: ";
    cin >> chemia;

    double srednia = (Jpolski + matematyka + Jangielski + chemia) / 4;
}
