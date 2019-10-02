#pragma once

#ifdef IndividDLLA_EXPORTS
#define PLUGIN_API __declspec(dllexport)
#elif IndividDLLA_IMPORTS
#define PLUGIN_API __declspec(dllimport)
#else
#define PLUGIN_API
#endif