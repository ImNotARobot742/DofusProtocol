

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Dungeons")]
    public class Dungeon : IDataObject
    {
        public const String MODULE = "Dungeons";
        public int id;
        public uint nameId;
        public int optimalPlayerLevel;
        public List<double> mapIds;
        public double entranceMapId;
        public double exitMapId;
    }
}