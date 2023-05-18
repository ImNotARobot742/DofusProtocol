

// Generated on 05/18/2023 15:11:07
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Recipes")]
    public class Recipe : IDataObject
    {
        public const String MODULE = "Recipes";
        public int resultId;
        public uint resultNameId;
        public uint resultTypeId;
        public uint resultLevel;
        public List<int> ingredientIds;
        public List<uint> quantities;
        public int jobId;
        public int skillId;
        public String changeVersion;
        public double tooltipExpirationDate = NaN;
    }
}