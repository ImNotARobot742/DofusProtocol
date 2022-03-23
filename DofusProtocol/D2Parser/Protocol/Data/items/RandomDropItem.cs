

// Generated on 03/23/2022 09:51:49
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