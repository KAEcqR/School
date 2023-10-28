
#include <iostream>

using namespace std;

int main()
{
    //int klasa = 5;
    //const int* wKlasa = nullptr;

    //wKlasa = &klasa;
    // *wKlasa = 3 jest nie dozwolone
    //cout << wKlasa << endl;

    //int zmienna1 = 1;
    //int zmienna2 = 2;

    //int* const wskaznik = &zmienna1;

    //cout << wskaznik << endl;
    
    int* wskaznik = nullptr;

    wskaznik = new int; 

    *wskaznik = 4; 

    cout << "Ocena: " << *wskaznik << endl;
    delete wskaznik;
}
