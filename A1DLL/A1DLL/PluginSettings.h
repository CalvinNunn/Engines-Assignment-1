#pragma once

#ifdef A1DLL_EXPORTS
#define PLUGIN_API __declspec(dllexport)
#elif A1DLL_IMPORTS
#define PLUGIN_API __declspec(dllimport)
#else
#define PLUGIN_API
#endif