

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SpellVariants")]
    public class SpellVariant : IDataObject
    {
        public const String MODULE = "SpellVariants";
        public int id;
        public uint breedId;
        public List<uint> spellIds;
    }
}