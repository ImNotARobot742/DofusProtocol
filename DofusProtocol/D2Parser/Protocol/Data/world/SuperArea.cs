

// Generated on 06/02/2023 19:01:32
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SuperAreas")]
    public class SuperArea : IDataObject
    {
        public const String MODULE = "SuperAreas";
        public int id;
        public uint nameId;
        public uint worldmapId;
        public Boolean hasWorldMap;
    }
}