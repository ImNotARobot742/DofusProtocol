

// Generated on 06/13/2023 17:00:10
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