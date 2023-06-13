

// Generated on 06/13/2023 17:00:11
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