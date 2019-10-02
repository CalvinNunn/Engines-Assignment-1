#pragma once

#include "PluginSettings.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

class PLUGIN_API SaveLoad {
public:
    ofstream myfile;
    ifstream lfile;
    void saveFile(float x, float y, float z);
    int loadFileX();
	int loadFileY();
	int loadFileZ();

};