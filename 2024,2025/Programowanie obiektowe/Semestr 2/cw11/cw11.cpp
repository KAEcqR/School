#include <iostream>
#include <cmath>

using namespace std;

class Promien {
	double _r;
public: 
	void setPromien(double r) {
		_r = r;
	}

	double getPromien() {
		return _r;
	}


};

class Kolo {
public:
	double pole(Promien pPromien);
	double obwod(Promien pPromien);
};

class Kula {

};


int main()
{

}
