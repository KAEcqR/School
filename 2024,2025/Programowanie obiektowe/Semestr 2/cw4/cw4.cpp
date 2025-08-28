#include <iostream>
#include <vector>
#include <cmath>

using namespace std;

class Polygon {
    vector<int> sides;
public:
    Polygon(vector<int> args) {
		sides = args;
    }
    
    int perimeter() {
        int p = 0;
        for (int side : sides) {
            p += side;
        }
		return p;
    }

    virtual double area() = 0; 
};

class Rectangle : public Polygon {
    int a, b;
public:
    Rectangle(int a, int b) : Polygon({ a, a, b, b }) {
        this->a = a;
        this->b = b;
    }

	double area() {
		return a * b;
    }
};

class Square : public Rectangle {
    int a;
public:
    Square(int a) : Rectangle(a, a) {
        this->a = a;
    }

    double area() {
        return a * a;
    }
};

class Triangle : public Polygon {
	int a, b, c;
public : 
	Triangle(int a, int b, int c) : Polygon({ a, b, c }) {
		this->a = a;
		this->b = b;
		this->c = c;
	}

	double area() {
		double s = perimeter() / 2.0;
		return sqrt(s * (s - a) * (s - b) * (s - c));
	}

int main()
{
    Rectangle rectangle(8, 9);
	cout << "Obwod: " << rectangle.perimeter() << endl;
	cout << "Pole: " << rectangle.area() << endl;
}