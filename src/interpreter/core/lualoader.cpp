#include "lualoader.h"
#include "lualoaderapi.h"

if ((iErr = luaL_loadfile (lua, file)) == 0)
{
    lua_pushcclosure (lua, opts, 0);
}
