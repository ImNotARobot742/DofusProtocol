

// Generated on 06/02/2023 19:01:31
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MonsterRaces")]
    public class MonsterRace : IDataObject
    {
        public const String MODULE = "MonsterRaces";
        public int id;
        public int superRaceId;
        public uint nameId;
        public List<uint> monsters;
        public int aggressiveZoneSize;
        public int aggressiveLevelDiff;
        public String aggressiveImmunityCriterion;
        public int aggressiveAttackDelay;
    }
}