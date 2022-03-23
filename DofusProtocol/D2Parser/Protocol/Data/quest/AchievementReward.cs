

// Generated on 03/23/2022 09:51:50
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AchievementRewards")]
    public class AchievementReward : IDataObject
    {
        public const String MODULE = "AchievementRewards";
        public uint id;
        public uint achievementId;
        public String criteria;
        public double kamasRatio;
        public double experienceRatio;
        public Boolean kamasScaleWithPlayerLevel;
        public List<uint> itemsReward;
        public List<uint> itemsQuantityReward;
        public List<uint> emotesReward;
        public List<uint> spellsReward;
        public List<uint> titlesReward;
        public List<uint> ornamentsReward;
    }
}