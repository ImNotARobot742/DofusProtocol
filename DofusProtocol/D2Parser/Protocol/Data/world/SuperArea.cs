

// Generated on 05/18/2023 15:11:08
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