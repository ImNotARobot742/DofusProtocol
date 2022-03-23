

// Generated on 03/23/2022 09:51:50
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