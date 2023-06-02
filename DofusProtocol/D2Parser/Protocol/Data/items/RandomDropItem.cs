

// Generated on 06/02/2023 19:01:30
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("RandomDropItem")]
    public class RandomDropItem : IDataObject
    {
        public uint id;
        public uint itemId;
        public double probability;
        public uint minQuantity;
        public uint maxQuantity;
    }
}