#include <iostream>

using namespace std;

int main()
{
    int bok1, bok2, pole;
    int* w_bok1 = nullptr;
    int* w_bok2 = nullptr;
    int* w_pole = nullptr;

    w_bok1 = &bok1;
    w_bok2 = &bok2;
    w_pole = &polde;

    cout << "1 bok: " << endl;
    cin >> *w_bok1;

    cout << "2 bok: " << endl;
    cin >> *w_bok2;

    *w_pole = (*w_bok1) * (*w_bok2);

    cout << "Pole to " << *w_pole;

}
