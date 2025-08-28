#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    fstream myFile;
    
    myFile.open("plik.txt", ios::out); //write
    if (myFile.is_open()) {
        myFile << "Czesc\n";
        myFile << "Druga linijka\n";
        myFile.close();
    }

    myFile.open("plik.txt", ios::app); //Append
    if (myFile.is_open()) {
        myFile << "Czesc2\n";
        myFile << "Jakiœ tekst dalej\n";
        myFile.close();
    }

    myFile.open("plik.txt", ios::in); //write
    if (myFile.is_open()) {
        string line;
        while (getline(myFile, line)) {
            cout << line << endl;
        }
        myFile.close();
    }


}

