

// Generated on 06/13/2023 17:00:14
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AchievementProgressSteps")]
    public class AchievementProgressStep : IDataObject
    {
        public const String MODULE = "AchievementProgressSteps";
        public int id;
        public int progressId;
        public int score;
        public Boolean isCosmetic;
        public int achievementId;
    }
}