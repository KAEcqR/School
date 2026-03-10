#include <iostream>

using namespace std;

class Wyjatek : public exception {

};

int main()
{
    try {
        double licznik = 1, mianownik = 0;
        if (mianownik == 0) {
            throw Wyjatek(); 
        }
    }
    catch (exception& e) {
        cout << e.what() << endl;
    }
}
