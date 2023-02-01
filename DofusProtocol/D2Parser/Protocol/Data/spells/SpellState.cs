

// Generated on 02/01/2023 12:54:55
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SpellStates")]
    public class SpellState : IDataObject
    {
        public const String MODULE = "SpellStates";
        public int id;
        public uint nameId;
        public Boolean preventsSpellCast;
        public Boolean preventsFight;
        public Boolean isSilent;
        public Boolean cantDealDamage;
        public Boolean invulnerable;
        public Boolean incurable;
        public Boolean cantBeMoved;
        public Boolean cantBePushed;
        public Boolean cantSwitchPosition;
        public List<int> effectsIds;
        public String icon = "";
        public int iconVisibilityMask;
        public Boolean invulnerableMelee;
        public Boolean invulnerableRange;
        public Boolean cantTackle;
        public Boolean cantBeTackled;
        public Boolean displayTurnRemaining;
    }
}