

// Generated on 02/01/2023 12:54:54
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