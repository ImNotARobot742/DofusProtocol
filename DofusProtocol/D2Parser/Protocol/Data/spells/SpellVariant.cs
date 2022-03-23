

// Generated on 03/23/2022 09:51:51
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