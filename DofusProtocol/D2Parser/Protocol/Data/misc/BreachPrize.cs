

// Generated on 03/23/2022 09:51:50
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