

// Generated on 06/13/2023 17:00:13
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ForgettableSpells")]
    public class ForgettableSpell : IDataObject
    {
        public const String MODULE = "ForgettableSpells";
        public int id;
        public int pairId;
        public int itemId;
    }
}