

// Generated on 06/02/2023 19:01:29
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("EvolutiveItemTypes")]
    public class EvolutiveItemType : IDataObject
    {
        public const String MODULE = "EvolutiveItemTypes";
        public int id;
        public uint maxLevel;
        public double experienceBoost;
        public List<int> experienceByLevel;
    }
}