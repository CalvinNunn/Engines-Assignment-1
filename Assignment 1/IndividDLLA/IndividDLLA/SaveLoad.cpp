#include "SaveLoad.h"

void SaveLoad::saveFile(float x, float y, float z) {
    myfile.open("pos.txt");
    
    myfile << to_string(x) + "," + to_string(y) + "," + to_string(z);

    myfile.close();
}

int SaveLoad::loadFileX() {

    lfile.open("pos.txt");
    
	string line;


    if (lfile.is_open()) {
        while (getline(lfile, line)) {

        }

    }

    lfile.close();
	string subs = line.substr(0, line.find(","));
	int x = stoi(subs);
	return x;
}

int SaveLoad::loadFileY() {

	lfile.open("pos.txt");

	string line;


	if (lfile.is_open()) {
		while (getline(lfile, line)) {

		}

	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(0, subs.find(","));
	int y = stoi(subs2);

	return y;
}

int SaveLoad::loadFileZ() {
	lfile.open("pos.txt");

	string line;


	if (lfile.is_open()) {
		while (getline(lfile, line)) {

		}

	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(subs.find(",") + 1);
	int z = stoi(subs2);

	return z;
}