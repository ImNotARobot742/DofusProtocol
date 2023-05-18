

// Generated on 05/18/2023 15:11:04
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("BreachWorldMapCoordinates")]
    public class BreachWorldMapCoordinate : IDataObject
    {
        public const String MODULE = "BreachWorldMapCoordinates";
        public uint id;
        public uint mapStage;
        public int mapCoordinateX;
        public int mapCoordinateY;
        public int unexploredMapIcon;
        public int exploredMapIcon;
    }
}