#include <iostream>
#include <cmath>

using namespace std;

class Punkt2d {
private: 
	double x;
	double y;
public:
	Punkt2d(double x = 0.0, double y = 0.0) {
		this->x = x;
		this->y = y;
	}

	double getX() {
		return x;
	}

	double getY() {
		return y;
	}
};

int main()
{
	Punkt2d p1;
	Punkt2d p2(3.0, 4.0);

	cout << "Punkt p1 ma wspolrzedne: (" << p1.getX() << ", " << p1.getY() << ")" << endl;


	return 0;
}
