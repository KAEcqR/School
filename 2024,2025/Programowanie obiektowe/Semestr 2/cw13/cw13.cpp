#include <iostream>
using namespace std;

class Silnik {
    double pojemnosc, spalanie; 

    friend class Samochod;
};

class Samochod {
    string marka, model;
    double paliwo;
    Silnik silnik;
public:
    Samochod(string marka = "Fiat", string model = "126p", double paliwo = 15, double pojemnosc = 650, double spalanie = 6.5) {
        this->marka = marka;
        this->model = model;
        this->silnik.pojemnosc = pojemnosc;
        this->silnik.spalanie = spalanie;
        this->paliwo = paliwo;
    }

    void Info() {
        cout << "Marka: " << marka << endl;
    }
};

double zasieg(Samochod s, int dystans) {

}

int main()
{
   
}
