#include "Wrapper.h"

FileIO sl;

void saveFile(float x, float y, float z, float sX, float sY, float sZ) {

	return sl.saveFile(x, y, z, sX, sY, sZ);
}

int loadFileX(int i) {

	return sl.loadFileX(i);
}

int loadFileY(int i) {

	return sl.loadFileY(i);
}

int loadFileZ(int i) {

	return sl.loadFileZ(i);
}

 void clearFile()
{
	 return sl.clearFile();
}

 int loadFileSX(int i)
{
	 return sl.loadFileSX(i);
}

 int loadFileSY(int i)
{
	 return sl.loadFileSY(i);
}

 int loadFileSZ(int i)
{
	 return sl.loadFileSZ(i);
}
 
 int getLines() {
	 return sl.getLines();
 }

