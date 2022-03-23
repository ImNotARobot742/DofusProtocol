

// Generated on 03/23/2022 09:51:50
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("CompanionSpells")]
    public class CompanionSpell : IDataObject
    {
        public const String MODULE = "CompanionSpells";
        public int id;
        public int spellId;
        public int companionId;
        public String gradeByLevel;
    }
}