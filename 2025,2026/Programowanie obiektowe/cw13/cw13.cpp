#include <iostream>
#include <string>

using namespace std;

class Pytanie {
private:
    string pytanie;
    string path;
    bool isCorrect;

public:
    Pytanie(string pytanie, string path) : 
        pytanie(pytanie), path(path), isCorrect(false) {}

};

int main()
{
    std::cout << "Hello World!\n";
}
