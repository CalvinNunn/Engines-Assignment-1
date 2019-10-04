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
	void saveFile(float x, float y, float z, float sX, float sY, float sZ);
	void clearFile();
	int loadFileX(int i);
	int loadFileY(int i);
	int loadFileZ(int i);

	int loadFileSX(int i);
	int loadFileSY(int i);
	int loadFileSZ(int i);
	int getLines();

};