

// Generated on 02/01/2023 12:54:54
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Spells")]
    public class Spell : IDataObject
    {
        public const String MODULE = "Spells";
        public int id;
        public uint nameId;
        public uint descriptionId;
        public uint typeId;
        public uint order;
        public String scriptParams;
        public String scriptParamsCritical;
        public int scriptId;
        public int scriptIdCritical;
        public int iconId;
        public List<uint> spellLevels;
        public Boolean useParamCache = true;
        public Boolean verbose_cast;
        public String default_zone;
        public Boolean bypassSummoningLimit;
        public Boolean canAlwaysTriggerSpells;
        public String adminName;
    }
}