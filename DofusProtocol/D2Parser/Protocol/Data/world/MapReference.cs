

// Generated on 02/01/2023 12:54:55
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MapReferences")]
    public class MapReference : IDataObject
    {
        public const String MODULE = "MapReferences";
        public int id;
        public double mapId;
        public int cellId;
    }
}