#include "Wrapper.h"

SaveLoad sl;

void saveFile(float x, float y, float z) {

    return sl.saveFile(x, y, z);
}

int loadFileX() {

    return sl.loadFileX();
}

int loadFileY() {

	return sl.loadFileY();
}

int loadFileZ() {

	return sl.loadFileZ();
}