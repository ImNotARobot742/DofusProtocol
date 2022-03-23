

// Generated on 03/23/2022 09:51:51
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("QuestSteps")]
    public class QuestStep : IDataObject
    {
        public const String MODULE = "QuestSteps";
        public uint id;
        public uint questId;
        public uint nameId;
        public uint descriptionId;
        public int dialogId;
        public uint optimalLevel;
        public double duration;
        public List<uint> objectiveIds;
        public List<uint> rewardsIds;
    }
}