

// Generated on 06/13/2023 17:00:14
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