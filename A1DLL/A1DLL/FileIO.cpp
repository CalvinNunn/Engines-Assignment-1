#include "FileIO.h"


void FileIO::saveFile(float x, float y, float z, float sX, float sY, float sZ) {
	myfile.open("pos.txt", ios::app);


	myfile << to_string(x) + "," + to_string(y) + "," + to_string(z) + "," + to_string(sX) + "," + to_string(sY) + "," + to_string(sZ) << endl;


	myfile.close();
}

void FileIO::clearFile() {
	myfile.clear();
}

int FileIO::loadFileX(int i) {

	lfile.open("pos.txt");

	string line;


	if (lfile.is_open()) {
		for (int j = 0; j < i; j++) {
			getline(lfile, line);

			
		}
	}

	lfile.close();
	string subs = line.substr(0, line.find(","));
	int x = stoi(subs);
	return x;
}

int FileIO::loadFileY(int i) {

	lfile.open("pos.txt");

	string line;


		if (lfile.is_open()) {
			for (int j = 0; j < i; j++) {
				getline(lfile, line);


			}
		

	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(0, subs.find(","));
	int y = stoi(subs2);

	return y;
}

int FileIO::loadFileZ(int i) {
	lfile.open("pos.txt");

	string line;


	
		if (lfile.is_open()) {
			for (int j = 0; j < i; j++) {
				getline(lfile, line);


			}
	
		

	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(subs.find(",") + 1);
	int z = stoi(subs2);

	return z;
}

int FileIO::loadFileSX(int i)
{
	lfile.open("pos.txt");

	string line;


	if (lfile.is_open()) {
		for (int j = 0; j < i; j++) {
			getline(lfile, line);


		}
	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(subs.find(",") + 1);
	string subs3 = subs2.substr(subs2.find(","));
	int x = stoi(subs3);

	return x;
}

int FileIO::loadFileSY(int i)
{
	lfile.open("pos.txt");

	string line;


	if (lfile.is_open()) {
		for (int j = 0; j < i; j++) {
			getline(lfile, line);


		}
	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(subs.find(",") + 1);
	string subs3 = subs2.substr(subs2.find(",") + 1);
	string subs4 = subs3.substr(subs3.find(","));
	int y = stoi(subs4);

	return y;
}

int FileIO::loadFileSZ(int i)
{
	lfile.open("pos.txt");

	string line;


	if (lfile.is_open()) {
		for (int j = 0; j < i; j++) {
			getline(lfile, line);


		}
	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(subs.find(",") + 1);
	string subs3 = subs2.substr(subs2.find(",") + 1);
	string subs4 = subs3.substr(subs3.find(",") + 1);
	int z = stoi(subs4);

	return z;
}

int FileIO::getLines() {

	int numLines = 0;
	string line;
	ifstream myfile("pos.txt");

	while (getline(myfile, line)){
		++numLines;

	}
	return numLines;
}


