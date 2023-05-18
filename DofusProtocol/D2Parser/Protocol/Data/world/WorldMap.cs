

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("WorldMaps")]
    public class WorldMap : IDataObject
    {
        public const String MODULE = "WorldMaps";
        public int id;
        public uint nameId;
        public int origineX;
        public int origineY;
        public double mapWidth;
        public double mapHeight;
        public Boolean viewableEverywhere;
        public double minScale;
        public double maxScale;
        public double startScale;
        public int totalWidth;
        public int totalHeight;
        public List<String> zoom;
        public Boolean visibleOnMap;
    }
}