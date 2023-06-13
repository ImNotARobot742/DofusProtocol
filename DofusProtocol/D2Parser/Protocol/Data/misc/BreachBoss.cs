

// Generated on 06/13/2023 17:00:12
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("BreachBosses")]
    public class BreachBoss : IDataObject
    {
        public const String MODULE = "BreachBosses";
        public int id;
        public int monsterId;
        public int category;
        public String apparitionCriterion;
        public String accessCriterion;
        public List<int> incompatibleBosses;
        public uint rewardId;
    }
}