

// Generated on 03/23/2022 09:51:51
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