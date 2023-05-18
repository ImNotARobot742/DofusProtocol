

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MapCoordinates")]
    public class MapCoordinates : IDataObject
    {
        public const String MODULE = "MapCoordinates";
        public uint compressedCoords;
        public List<double> mapIds;
    }
}