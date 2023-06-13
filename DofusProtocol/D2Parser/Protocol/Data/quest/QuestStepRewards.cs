

// Generated on 06/13/2023 17:00:13
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("QuestStepRewards")]
    public class QuestStepRewards : IDataObject
    {
        public const String MODULE = "QuestStepRewards";
        public uint id;
        public uint stepId;
        public int levelMin;
        public int levelMax;
        public double kamasRatio;
        public double experienceRatio;
        public Boolean kamasScaleWithPlayerLevel;
        public List<List<uint>> itemsReward;
        public List<uint> emotesReward;
        public List<uint> jobsReward;
        public List<uint> spellsReward;
        public List<uint> titlesReward;
    }
}