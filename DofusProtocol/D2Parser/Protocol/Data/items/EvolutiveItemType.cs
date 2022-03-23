

// Generated on 03/23/2022 09:51:48
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