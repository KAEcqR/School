#include <iostream>

int main()
{
    int bok1, bok2;

    std::cout << "Obliczanie Pola Prostokata\n";
    std::cout << "Podaj pierwszy bok: ";
    std::cin >> bok1;
    std::cout << "Podaj drugi bok: ";
    std::cin >> bok2;
    std::cout << "Pole Twojego Prostokata wynosi: " << bok1 * bok2 << std::endl;
    std::cout << "Obwod Twojego Prostokata wynosi: " << 2 * bok1 + 2 * bok2;
}
