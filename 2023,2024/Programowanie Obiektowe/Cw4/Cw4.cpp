#include <iostream>

int main()
{
    int r;
    const double PI = 3.14159;
    std::cout << "Podaj promien: \n";
    std::cin >> r;

    if (r > 0) {
        std::cout << "Pole wynosi: " << PI * (r * r) << std::endl;
        std::cout << "Obwod wynosi: " << 2 * PI * r;
    }
    else {
        std::cout << "Promien musi byc wiekszy od 0";
    }

}