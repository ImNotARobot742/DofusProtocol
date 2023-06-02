

// Generated on 06/02/2023 19:01:29
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