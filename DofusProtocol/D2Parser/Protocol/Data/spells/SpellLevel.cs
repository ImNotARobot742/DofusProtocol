

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SpellLevels")]
    public class SpellLevel : IDataObject
    {
        public const String MODULE = "SpellLevels";
        public uint id;
        public uint spellId;
        public uint grade;
        public uint spellBreed;
        public uint apCost;
        public uint minRange;
        public uint range;
        public Boolean castInLine;
        public Boolean castInDiagonal;
        public Boolean castTestLos;
        public uint criticalHitProbability;
        public Boolean needFreeCell;
        public Boolean needTakenCell;
        public Boolean needFreeTrapCell;
        public Boolean rangeCanBeBoosted;
        public int maxStack;
        public uint maxCastPerTurn;
        public uint maxCastPerTarget;
        public uint minCastInterval;
        public uint initialCooldown;
        public int globalCooldown;
        public uint minPlayerLevel;
        public Boolean hideEffects;
        public Boolean hidden;
        public Boolean playAnimation;
        public String statesCriterion;
        public List<EffectInstanceDice> effects;
        public List<EffectInstanceDice> criticalEffect;
        public List<String> additionalEffectsZones;
    }
}