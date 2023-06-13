

// Generated on 06/13/2023 17:00:10
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