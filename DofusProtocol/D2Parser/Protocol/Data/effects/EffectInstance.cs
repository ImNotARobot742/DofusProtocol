

// Generated on 03/23/2022 09:51:48
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("EffectInstance")]
    public class EffectInstance : IDataObject
    {
        public const int IS_DISPELLABLE = 1;
        public const int IS_DISPELLABLE_ONLY_BY_DEATH = 2;
        public const int IS_NOT_DISPELLABLE = 3;
        public uint effectUid;
        public uint baseEffectId;
        public uint effectId;
        public int order;
        public int targetId;
        public String targetMask;
        public int duration;
        public int delay;
        public double random;
        public int group;
        public int modificator;
        public Boolean trigger;
        public String triggers;
        public Boolean visibleInTooltip = true;
        public Boolean visibleInBuffUi = true;
        public Boolean visibleInFightLog = true;
        public Boolean visibleOnTerrain = true;
        public Boolean forClientOnly = false;
        public int dispellable = 1;
        public Object zoneSize;
        public uint zoneShape;
        public Object zoneMinSize;
        public Object zoneEfficiencyPercent;
        public Object zoneMaxEfficiency;
        public Object zoneStopAtTarget;
        public int effectElement;
        public int spellId;
        public String rawZone;
    }
}