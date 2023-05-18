

// Generated on 05/18/2023 15:11:07
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