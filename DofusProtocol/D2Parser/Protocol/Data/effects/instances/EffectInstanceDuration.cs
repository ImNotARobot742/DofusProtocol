

// Generated on 03/23/2022 09:51:48
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("EffectInstanceDuration")]
    public class EffectInstanceDuration : EffectInstance
    {
        public uint days;
        public uint hours;
        public uint minutes;
    }
}