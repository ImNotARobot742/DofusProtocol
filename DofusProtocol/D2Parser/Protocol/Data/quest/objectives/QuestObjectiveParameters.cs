

// Generated on 02/01/2023 12:54:54
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("QuestObjectiveParameters")]
    public class QuestObjectiveParameters : IDataObject
    {
        public uint numParams;
        public int parameter0;
        public int parameter1;
        public int parameter2;
        public int parameter3;
        public int parameter4;
        public Boolean dungeonOnly;
    }
}