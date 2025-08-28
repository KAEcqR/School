#include <iostream>
#include <cmath>

using namespace std;

struct Punkt {
    double x;
    double y;
};

class Odleglosc {
private:
    Punkt p1;
    Punkt p2;

public:

    Odleglosc() : p1{ 0.0, 0.0 }, p2{ 0.0, 0.0 } {}

    Odleglosc(double x1, double y1, double x2, double y2)
        : p1{ x1, y1 }, p2{ x2, y2 } {}

    ~Odleglosc() {}

    double oblicz() {
        return sqrt(pow(p2.x - p1.x, 2) + pow(p2.y - p1.y, 2));
    }
};

int main() {
    double x1, y1, x2, y2;

    cout << "Podaj współrzędne pierwszego punktu (x1, y1): ";
    cin >> x1 >> y1;
    cout << "Podaj współrzędne drugiego punktu (x2, y2): ";
    cin >> x2 >> y2;

    Odleglosc odl(x1, y1, x2, y2);

    cout << "Odległość pomiędzy punktami wynosi: " << odl.oblicz() << endl;

    return 0;
}
