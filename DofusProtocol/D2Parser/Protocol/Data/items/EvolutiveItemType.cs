

// Generated on 02/01/2023 12:54:52
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