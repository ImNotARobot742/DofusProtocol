

// Generated on 03/23/2022 09:51:51
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