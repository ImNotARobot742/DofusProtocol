

// Generated on 06/13/2023 17:00:10
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