

// Generated on 03/23/2022 09:51:48
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