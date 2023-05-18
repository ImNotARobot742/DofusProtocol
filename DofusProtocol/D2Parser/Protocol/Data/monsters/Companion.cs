

// Generated on 05/18/2023 16:29:45
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Companions")]
    public class Companion : IDataObject
    {
        public const String MODULE = "Companions";
        public int id;
        public uint nameId;
        public String look;
        public Boolean webDisplay;
        public uint descriptionId;
        public uint startingSpellLevelId;
        public uint assetId;
        public List<uint> characteristics;
        public List<uint> spells;
        public int creatureBoneId;
        public String visibility;
    }
}