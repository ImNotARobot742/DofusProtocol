

// Generated on 05/18/2023 15:11:05
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("EffectInstanceDate")]
    public class EffectInstanceDate : EffectInstance
    {
        public uint year;
        public uint month;
        public uint day;
        public uint hour;
        public uint minute;
    }
}