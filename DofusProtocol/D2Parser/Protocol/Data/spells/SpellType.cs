

// Generated on 05/18/2023 16:29:46
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SpellTypes")]
    public class SpellType : IDataObject
    {
        public const String MODULE = "SpellTypes";
        public int id;
        public uint longNameId;
        public uint shortNameId;
    }
}