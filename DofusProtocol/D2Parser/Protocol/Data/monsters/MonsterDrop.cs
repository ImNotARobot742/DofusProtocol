

// Generated on 05/18/2023 15:11:07
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MonsterDrop")]
    public class MonsterDrop : IDataObject
    {
        public uint dropId;
        public int monsterId;
        public int objectId;
        public double percentDropForGrade1;
        public double percentDropForGrade2;
        public double percentDropForGrade3;
        public double percentDropForGrade4;
        public double percentDropForGrade5;
        public int count;
        public String criteria;
        public Boolean hasCriteria;
        public Boolean hiddenIfInvalidCriteria;
        public List<MonsterDropCoefficient> specificDropCoefficient;
    }
}