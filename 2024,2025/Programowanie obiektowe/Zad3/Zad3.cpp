#include <iostream>

using namespace std;

class Prostokat {
public:
    double sz;
    double dl;

    Prostokat() : dl(1.0), sz(1.0) {}

    Prostokat(const Prostokat& p) : dl(p.dl), sz(p.sz) {}

    double obliczPole() {
        return dl * sz;
    }

    double obliczObwod() {
        return 2 * (dl + sz);
    }
};

int main() {
    Prostokat domyslnePomieszczenie;
    Prostokat pokoje[4] = { domyslnePomieszczenie, domyslnePomieszczenie, domyslnePomieszczenie, domyslnePomieszczenie };

    for (int i = 0; i < 4; ++i) {
        cout << "Podaj szerokość pokoju " << i + 1 << ": ";
        cin >> pokoje[i].sz;
        cout << "Podaj długość pokoju " << i + 1 << ": ";
        cin >> pokoje[i].dl;
    }

    cout << "\nWyniki obliczeń dla pokoi:" << endl;
    for (int i = 0; i < 4; ++i) {
        cout << "Pokój " << i + 1 << " - Pole: " << pokoje[i].obliczPole()
            << ", Obwód: " << pokoje[i].obliczObwod() << endl;
    }
}
