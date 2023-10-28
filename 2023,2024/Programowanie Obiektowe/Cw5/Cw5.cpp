#include <cmath>
#include <iostream>

using namespace std;

int main()
{   
    double a = 1, b = 5, c = 4;
    double delta = b * b - 4 * a * c;
    cout << "Delta wynosi: " << delta << endl;

    if (delta > 0) {
        double x1 = ( - b - sqrt(delta)) / 2 * a;
        double x2 = ( - b + sqrt(delta)) / 2 * a;
        cout << "Pierwiastek1 = " << x1 << endl;
        cout << "Pierwiastek2 = " << x2 << endl;
    }
    else if (delta == 0) {
        double x0 = -b / (2 * a);
        cout << "Pierwiastek = " << x0 << endl;
    }
    else {
        cout << "Rownanie nie ma pierwiastkow rzeczywistych";
    }
}

