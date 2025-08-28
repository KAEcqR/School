#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;

struct Album {
    string artist, album;
    int songsNumber;
    int year;
    long downloadNumber;
};

void readFile(string path, vector<Album>& list) {
    fstream myFile;
	myFile.open(path, ios::in);
	if (myFile.is_open()) {
        string line;
        Album album;
        int count = 1;
        while (getline(myFile, line)) {
			switch (count) {
            case 1: album.artist = line; break;
            case 2: album.album = line; break;
            case 3: album.songsNumber = stoi(line); break;
            case 4: album.year = stoi(line); break;
            case 5: album.downloadNumber = stoi(line); break;
			case 6: list.push_back(album); break;
            }
            count++;
        }
    }
	myFile.close();
}

int main()
{
    
}
