

// Generated on 06/13/2023 17:00:13
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SpellPairs")]
    public class SpellPair : IDataObject
    {
        public const String MODULE = "SpellPairs";
        public int id;
        public uint nameId;
        public uint descriptionId;
        public int iconId;
    }
}