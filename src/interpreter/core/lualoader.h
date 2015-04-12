// (C)2015 Matheus Silva
#include <stdio.h>
#include <stdlib.h>
#include <cstdlib>
#include <iostream>
#include <fstream>
#include <string>
#include <streambuf>
#include <sstream>
#include <bitset>
#include <regex>
#include <direct.h>
#include <ctime>

#ifndef __LUA_INC_H__
#define __LUA_INC_H__

extern "C"
{
    #include "../../vendor/lua/src/lua.h"
    #include "../../vendor/lua/src/lauxlib.h"
    #include "../../vendor/lua/src/lualib.h"
}

#endif // __LUA_INC_H__

using namespace std;
int iErr = 0;
lua_State *lua = lua_open(); // Open lua
luaopen_io (lua); // Load io lib
