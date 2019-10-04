#pragma once

#include "PluginSettings.h"
#include "FileIO.h"

#ifdef __cplusplus
extern "C"
{
#endif

	PLUGIN_API void saveFile(float x, float y, float z, float sX, float sY, float sZ, string name);
	PLUGIN_API int loadFileX(int i, string name);
	PLUGIN_API int loadFileY(int i, string name);
	PLUGIN_API int loadFileZ(int i, string name);
	PLUGIN_API void clearFile(string name);
	PLUGIN_API int loadFileSX(int i, string name);
	PLUGIN_API int loadFileSY(int i, string name);
	PLUGIN_API int loadFileSZ(int i, string name);
	PLUGIN_API int getLines(string name);


#ifdef __cplusplus
}
#endif