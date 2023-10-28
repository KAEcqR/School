#include <iostream>

using namespace std;

int main()
{

    int liczbaDniMiesiaca;

    cout <<  "DO WHILE" << endl;

    do {
        cout << "Podaj lilczbe dni w miesiacu: ";
        cin >> liczbaDniMiesiaca;
    } while (liczbaDniMiesiaca < 28 || liczbaDniMiesiaca > 31);

    cout << endl << "FOR" << endl;

    for (int i = 1; i <= liczbaDniMiesiaca; i++) {
        if (i % 7 == 0) {
            cout << i << "\t" << endl;
        }
        else {
            cout << i << "\t";
        }
    };

    cout << endl << "WHILE" << endl;

    int i = 1;

    while (i <= liczbaDniMiesiaca) {
        if (i % 7 == 0) {
            cout << i << "\t" << endl;
        }
        else {
            cout << i << "\t";
        }
        i++;
    };

}
