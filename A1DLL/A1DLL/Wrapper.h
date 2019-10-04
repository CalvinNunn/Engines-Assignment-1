#pragma once

#include "PluginSettings.h"
#include "FileIO.h"

#ifdef __cplusplus
extern "C"
{
#endif

	PLUGIN_API void saveFile(float x, float y, float z, float sX, float sY, float sZ);
	PLUGIN_API int loadFileX(int i);
	PLUGIN_API int loadFileY(int i);
	PLUGIN_API int loadFileZ(int i);
	PLUGIN_API void clearFile();
	PLUGIN_API int loadFileSX(int i);
	PLUGIN_API int loadFileSY(int i);
	PLUGIN_API int loadFileSZ(int i);
	PLUGIN_API int getLines();


#ifdef __cplusplus
}
#endif