

// Generated on 05/18/2023 15:11:05
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SmileyPacks")]
    public class SmileyPack : IDataObject
    {
        public const String MODULE = "SmileyPacks";
        public uint id;
        public uint nameId;
        public uint order;
        public List<uint> smileys;
    }
}