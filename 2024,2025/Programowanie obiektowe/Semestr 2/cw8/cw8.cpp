#include <iostream>

using namespace std;

void bubbleSort(float t[], int n) {
	int i, j;
	float temp;
	for (i = 0; i < n; i++) {
		for (j = i + 1; j < n; j++) {
			if (t[j] < t[i]) {
				temp = t[i];
				t[i] = t[j];
				t[j] = temp;
			}
		}
	}
}

void fillArray() {
	srand(time(NULL));
	int i;
	int tablica[20];
	for (i = 0; i < 20; i++) {
		int liczba = (std::rand() % 100);
		tablica[i] = liczba;
	}
}

int main()
{

}
