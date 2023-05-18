

// Generated on 05/18/2023 16:29:44
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("LegendaryPowersCategories")]
    public class LegendaryPowerCategory : IDataObject
    {
        public const String MODULE = "LegendaryPowersCategories";
        public int id;
        public String categoryName;
        public Boolean categoryOverridable;
        public List<int> categorySpells;
    }
}