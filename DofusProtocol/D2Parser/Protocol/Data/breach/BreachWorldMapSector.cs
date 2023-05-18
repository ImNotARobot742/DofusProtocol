

// Generated on 05/18/2023 15:11:04
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("BreachWorldMapSectors")]
    public class BreachWorldMapSector : IDataObject
    {
        public const String MODULE = "BreachWorldMapSectors";
        public uint id;
        public uint sectorNameId;
        public uint legendId;
        public String sectorIcon;
        public int minStage;
        public int maxStage;
    }
}