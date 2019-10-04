#include "FileIO.h"


void FileIO::saveFile(float x, float y, float z, float sX, float sY, float sZ, string name) {
	
	myfile.open(name + ".txt", ios::app);

	myfile << to_string(x) + "," + to_string(y) + "," + to_string(z) + "," + to_string(sX) + "," + to_string(sY) + "," + to_string(sZ) << endl;

	myfile.close();
}

void FileIO::clearFile(string name) {
	myfile.open(name + ".txt");
	myfile.clear();
}

int FileIO::loadFileX(int i, string name) {

	lfile.open(name + ".txt");

	string line;


	if (lfile.is_open()) {
		for (int j = 0; j <= i; j++) {
			getline(lfile, line);

			
		}
	}

	lfile.close();
	string subs = line.substr(0, line.find(","));
	int x = stoi(subs);
	return x;
}

int FileIO::loadFileY(int i, string name) {

	lfile.open(name + ".txt");

	string line;


		if (lfile.is_open()) {
			for (int j = 0; j <= i; j++) {
				getline(lfile, line);


			}
		

	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(0, subs.find(","));
	int y = stoi(subs2);

	return y;
}

int FileIO::loadFileZ(int i, string name) {
	lfile.open(name + ".txt");

	string line;


	
		if (lfile.is_open()) {
			for (int j = 0; j <= i; j++) {
				getline(lfile, line);


			}
	
		

	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(subs.find(",") + 1);
	int z = stoi(subs2);

	return z;
}

int FileIO::loadFileSX(int i, string name)
{
	lfile.open(name + ".txt");

	string line;


	if (lfile.is_open()) {
		for (int j = 0; j <= i; j++) {
			getline(lfile, line);


		}
	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(subs.find(",") + 1);
	string subs3 = subs2.substr(subs2.find(",") + 1);
	int x = stoi(subs3.substr(0, subs3.find(",")));

	return x;
}

int FileIO::loadFileSY(int i, string name)
{
	lfile.open(name + ".txt");

	string line;


	if (lfile.is_open()) {
		for (int j = 0; j <= i; j++) {
			getline(lfile, line);


		}
	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(subs.find(",") + 1);
	string subs3 = subs2.substr(subs2.find(",") + 1);
	string subs4 = subs3.substr(subs3.find(",") + 1);
	int y = stoi(subs4.substr(0,subs4.find(",")));

	return y;
}

int FileIO::loadFileSZ(int i, string name)
{
	lfile.open(name + ".txt");

	string line;


	if (lfile.is_open()) {
		for (int j = 0; j <= i; j++) {
			getline(lfile, line);


		}
	}

	lfile.close();
	string subs = line.substr(line.find(",") + 1);
	string subs2 = subs.substr(subs.find(",") + 1);
	string subs3 = subs2.substr(subs2.find(",") + 1);
	string subs4 = subs3.substr(subs3.find(",") + 1);
	int z = stoi(subs4.substr(0,subs4.find(",")));

	return z;
}

int FileIO::getLines(string name) {

	int numLines = 0;
	string line;
	ifstream myfile(name + ".txt");

	while (getline(myfile, line)){
		++numLines;

	}
	return numLines;
}


