#include <iostream>

using namespace std;

class Student {
protected:
    string name;
public: 
    Student(string name) {
		this->name = name;
    }
    void print() {
        cout << name << endl;
    }
};

class MedicalStudent : public Student {
    string speciality;
public:
    MedicalStudent(string name, string speciality) : Student(name) {
        this->speciality = speciality;
    }

    void print() {
		cout << name << " - " << speciality << endl;
    }
};

int main()
{
    
}
