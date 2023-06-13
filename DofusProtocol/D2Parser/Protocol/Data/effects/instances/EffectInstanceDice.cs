

// Generated on 06/13/2023 17:00:10
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("EffectInstanceDice")]
    public class EffectInstanceDice : EffectInstanceInteger
    {
        public uint diceNum;
        public uint diceSide;
    }
}