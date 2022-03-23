

// Generated on 03/23/2022 09:51:48
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