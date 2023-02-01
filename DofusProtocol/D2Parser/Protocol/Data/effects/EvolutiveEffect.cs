

// Generated on 02/01/2023 12:54:51
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("EvolutiveEffects")]
    public class EvolutiveEffect : IDataObject
    {
        public const String MODULE = "EvolutiveEffects";
        public int id;
        public int actionId;
        public int targetId;
        public List<List<double>> progressionPerLevelRange;
    }
}