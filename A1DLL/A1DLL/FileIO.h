#pragma once

#include "PluginSettings.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

class PLUGIN_API FileIO {
public:
	ofstream myfile;
	ifstream lfile;
	void saveFile(float x, float y, float z, float sX, float sY, float sZ, string name);
	void clearFile(string name);
	int loadFileX(int i, string name);
	int loadFileY(int i, string name);
	int loadFileZ(int i, string name);

	int loadFileSX(int i, string name);
	int loadFileSY(int i, string name);
	int loadFileSZ(int i, string name);
	int getLines(string name);

};