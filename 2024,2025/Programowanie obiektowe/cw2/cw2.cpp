#include <iostream>

using namespace std;

class Prostokat {
    double bok1, bok2;
    string kolor;
public:
    Prostokat();
    Prostokat(double, double);
    Prostokat(const Prostokat&);
    ~Prostokat();

    double pole() {
        return bok1 * bok2;  
    };
    double obwod() {
        return 2 * bok1 + 2 * bok2;
    };

    void pokazBoki() {
        cout << "Bok a : " << bok1 << " Bok b : " << bok2;
    }

    void ustawBoki(double a, double b) {
        bok1 = a;
        bok2 = b;
    }

    void pokazKolor() {
        cout << "Kolor: " << kolor << endl;
    }
};

int main()
{
    Prostokat p1;

    Prostokat p2(6, 7);

    Prostokat p3 = p1;
    p3.pokazBoki();
}

Prostokat::Prostokat() {
    bok1 = 2;
    bok2 = 3;
    kolor = "biały";
    cout << "Wywolano konstruktor domyslny" << endl;
}

Prostokat::Prostokat(double a, double b) : Prostokat::Prostokat() {
    cout << "Wywolano konstruktor parametryczny" << endl;
}

Prostokat::Prostokat(const Prostokat& wzorzec)
{
    bok1 = wzorzec.bok1;
    bok2 = wzorzec.bok2;
    cout << "Wywolano konstruktor kopiujacy" << endl;
}

void rysujProstokat(Prostokat p) {
    cout << "Rysuje prostokat o bokach : ";
    p.pokazBoki();
}

Prostokat::~Prostokat() {
    cout << "Odpalenie destruktora" << endl;
}