

// Generated on 03/23/2022 09:51:47
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