#pragma once

#include "PluginSettings.h"
#include "SaveLoad.h"

#ifdef __cplusplus
extern "C"
{
#endif

    PLUGIN_API void saveFile(float x, float y, float z);

    PLUGIN_API int loadFileX();
	PLUGIN_API int loadFileY();
	PLUGIN_API int loadFileZ();

#ifdef __cplusplus
}
#endif