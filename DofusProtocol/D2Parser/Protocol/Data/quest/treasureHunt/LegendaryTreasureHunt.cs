

// Generated on 05/18/2023 16:29:46
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("LegendaryTreasureHunts")]
    public class LegendaryTreasureHunt : IDataObject
    {
        public const String MODULE = "LegendaryTreasureHunts";
        public uint id;
        public uint nameId;
        public uint level;
        public uint chestId;
        public uint monsterId;
        public uint mapItemId;
        public double xpRatio;
    }
}