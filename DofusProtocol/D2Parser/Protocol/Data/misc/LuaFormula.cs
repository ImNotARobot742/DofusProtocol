

// Generated on 03/23/2022 09:51:50
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