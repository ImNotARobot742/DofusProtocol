

// Generated on 06/13/2023 17:00:10
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Effects")]
    public class Effect : IDataObject
    {
        public const String MODULE = "Effects";
        public int id;
        public uint descriptionId;
        public int iconId;
        public int characteristic;
        public uint category;
        public String @operator;
        public Boolean showInTooltip;
        public Boolean useDice;
        public Boolean forceMinMax;
        public Boolean boost;
        public Boolean active;
        public int oppositeId;
        public uint theoreticalDescriptionId;
        public uint theoreticalPattern;
        public Boolean showInSet;
        public int bonusType;
        public Boolean useInFight;
        public uint effectPriority;
        public double effectPowerRate;
        public int elementId;
    }
}