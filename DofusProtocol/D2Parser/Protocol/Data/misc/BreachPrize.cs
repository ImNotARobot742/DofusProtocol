

// Generated on 05/18/2023 16:29:45
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("BreachPrizes")]
    public class BreachPrize : IDataObject
    {
        public const String MODULE = "BreachPrizes";
        public int id;
        public uint nameId;
        public int currency;
        public String tooltipKey;
        public uint descriptionKey;
        public int categoryId;
        public int itemId;
    }
}