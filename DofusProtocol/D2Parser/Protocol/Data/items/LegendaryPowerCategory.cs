

// Generated on 03/23/2022 09:51:49
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