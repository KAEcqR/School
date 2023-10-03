#include <iostream>

int main()
{   
    int liczba;
    std::cout << "Podaj liczbe\n";
    std::cin >> liczba;

    if (liczba > 0) {
        std::cout << "Modol z twojej liczby to: " << liczba;
    }
    else {
        std::cout << "Modol z twojej liczby to: " << -(liczba);
    }
}
