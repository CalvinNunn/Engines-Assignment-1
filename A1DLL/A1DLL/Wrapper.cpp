#include "Wrapper.h"

FileIO sl;

void saveFile(float x, float y, float z, float sX, float sY, float sZ, string name) {

	return sl.saveFile(x, y, z, sX, sY, sZ, name);
}

int loadFileX(int i, string name) {

	return sl.loadFileX(i, name);
}

int loadFileY(int i, string name) {

	return sl.loadFileY(i, name);
}

int loadFileZ(int i, string name) {

	return sl.loadFileZ(i, name);
}

 void clearFile(string name)
{
	 return sl.clearFile(name);
}

 int loadFileSX(int i, string name)
{
	 return sl.loadFileSX(i, name);
}

 int loadFileSY(int i, string name)
{
	 return sl.loadFileSY(i, name);
}

 int loadFileSZ(int i, string name)
{
	 return sl.loadFileSZ(i, name);
}
 
 int getLines(string name) {
	 return sl.getLines(name);
 }

