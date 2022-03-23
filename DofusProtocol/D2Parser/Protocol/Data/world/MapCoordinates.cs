

// Generated on 03/23/2022 09:51:51
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