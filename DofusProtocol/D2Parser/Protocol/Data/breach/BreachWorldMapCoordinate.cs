

// Generated on 06/02/2023 19:01:29
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