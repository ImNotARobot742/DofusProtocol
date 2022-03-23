

// Generated on 03/23/2022 09:51:50
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