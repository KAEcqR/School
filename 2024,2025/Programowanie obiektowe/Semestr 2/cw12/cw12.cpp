#define _USE_MATH_DEFINES
#include <iostream>
#include <cmath>

using namespace std;

class Promien {
	double _r; 
public : 
	void setPromien(double);
	double getPromien();

	friend class Kolo;
	friend class Kula;
};

class Kolo {
public:
	double pole(Promien);
	double obwod(Promien);

};

class Kula {
public:
	double pole(Promien);
	double objetosc(Promien);
};

int main() {
	
}