

// Generated on 06/13/2023 17:00:12
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MonsterDropCoefficient")]
    public class MonsterDropCoefficient : IDataObject
    {
        public uint monsterId;
        public uint monsterGrade;
        public double dropCoefficient;
        public String criteria;
    }
}