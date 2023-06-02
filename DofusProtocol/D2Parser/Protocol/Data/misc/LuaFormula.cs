

// Generated on 06/02/2023 19:01:31
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("LuaFormulas")]
    public class LuaFormula : IDataObject
    {
        public const String MODULE = "LuaFormulas";
        public int id;
        public String formulaName;
        public String luaFormula;
    }
}