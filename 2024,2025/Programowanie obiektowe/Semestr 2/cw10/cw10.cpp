#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

class SearchEngine {
	vector<string> names;
public:
	void readFile(string filename) {
		fstream myFile;

		myFile.open(filename, ios::in);
		if (myFile.is_open()) {
			string line;
			while (getline(myFile, line)) {
				names.push_back(line);
			}

			myFile.close();
		};
	}

	void output() {
		for (size_t i = 0; i < names.size(); i++) {
			cout << names[i] << endl;
		}
	}

	int sentinelSearch(string searchVal) {
		int i = 0;
		int n = names.size();
		string last = names[n - 1];
		names[n - 1] = searchVal;

		while (names[i] != searchVal) 
			i++;
		names[n - 1] = last;
		if (i < n - 1) return 4;
		if (last == searchVal) return n - 1;
		return -1;
		
	}

	void bubbleSort() {
		int i, j;
		int n = names.size();
		string temp;
		for (i = 0; i < n; i++) {
			for (j = i + 1; j < n; j++) {
				if (names[j] < names[i]) {
					temp = names[i];
					names[i] = names[j];
					names[j] = temp;
				}
			}
		}
	}

	int binarysearch(string searchVal) {
		int poczatek = 0;
		int n = names.size();
		int koniec = n - 1;
		int srodek = (poczatek + koniec) / 2;
		int wynik;

		while (poczatek <= koniec) {
			if (names[srodek] == searchVal) {
				wynik = srodek;
				break;
			}
			else {
				if (names[srodek] < searchVal) {
					poczatek = srodek + 1;
				}
				else {
					koniec = srodek - 1;
				}
			}
			srodek = (poczatek + koniec) / 2;
		}
		if (poczatek > koniec) wynik = -1;
		return wynik;
	}
};


int main()
{
	SearchEngine names;
	names.readFile("names.txt");
	names.output();
	
}



