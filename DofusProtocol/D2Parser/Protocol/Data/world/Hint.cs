

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Hints")]
    public class Hint : IDataObject
    {
        public const String MODULE = "Hints";
        public int id;
        public uint gfx;
        public uint nameId;
        public double mapId;
        public double realMapId;
        public int x;
        public int y;
        public Boolean outdoor;
        public int subareaId;
        public int worldMapId;
        public uint level;
    }
}