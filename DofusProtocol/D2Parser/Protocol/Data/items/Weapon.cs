

// Generated on 05/18/2023 16:29:44
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Weapon")]
    public class Weapon : Item
    {
        public int apCost;
        public int minRange;
        public int range;
        public uint maxCastPerTurn;
        public Boolean castInLine;
        public Boolean castInDiagonal;
        public Boolean castTestLos;
        public int criticalHitProbability;
        public int criticalHitBonus;
        public int criticalFailureProbability;
    }
}