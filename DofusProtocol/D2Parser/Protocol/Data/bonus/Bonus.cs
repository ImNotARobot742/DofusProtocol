

// Generated on 02/01/2023 12:54:50
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Bonuses")]
    public class Bonus : IDataObject
    {
        public const String MODULE = "Bonuses";
        public int id;
        public uint type;
        public int amount;
        public List<int> criterionsIds;
    }
}