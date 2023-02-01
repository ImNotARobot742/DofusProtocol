

// Generated on 02/01/2023 12:54:51
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("EffectInstanceMount")]
    public class EffectInstanceMount : EffectInstance
    {
        public double id;
        public double expirationDate;
        public uint model;
        public String name = "";
        public String owner = "";
        public uint level = 0;
        public Boolean sex = false;
        public Boolean isRideable = false;
        public Boolean isFeconded = false;
        public Boolean isFecondationReady = false;
        public int reproductionCount = 0;
        public uint reproductionCountMax = 0;
        public List<EffectInstanceInteger> effects;
        public List<uint> capacities;
    }
}