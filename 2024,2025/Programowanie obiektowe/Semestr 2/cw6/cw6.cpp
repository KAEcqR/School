#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    fstream myFile;

    myFile.open("plik.txt", ios::out);
	myFile.close();

	srand(time(NULL));

    myFile.open("plik.txt", ios::app);
    if (myFile.is_open()) {
        for (int i = 0; i < 10; i++)
        {
            int liczba = rand() % 100 ;
            myFile << liczba << "\n";
        }
        myFile.close();
    }

    double suma = 0;
    double srednia = 0;

    myFile.open("plik.txt", ios::in);
    if (myFile.is_open()) {
        string line;
        while (getline(myFile, line)) {
            suma = suma + stoi(line);
            cout << line << endl;
			srednia = suma / 10.0;
        }

		cout << "Suma : " << suma << endl;
        cout << "Srednia : " << srednia << endl;
        myFile.close();
    }

    
}

