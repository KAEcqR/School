#include <iostream>
#include <string>

using namespace std;

class Animal {
protected:
	string name;
	string age;

public: 
	Animal() {};
	Animal(string name, int age) {
		this->name = name;
		this->age = age;
	}
};

class Dog : Animal {
	string breed;
public: 
	Dog(string name, int age, string breed) : Animal(name, age){
		this->breed = breed;
	}

	string Info() {
		return name + " " + to_string(age) + " rasa: " + breed;
	}
};

class Cat : Animal {
	string breed;
public:
	Cat(string name, int age, string breed) : Animal(name, age) {
		this->breed = breed;
	}

	string Info() {
		return name + " " + to_string(age) + " rasa: " + breed;
	}
};

int main()
{
	Dog dog("burek", 5, "pudelek");
	dog.Info();
}