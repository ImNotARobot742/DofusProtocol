

// Generated on 05/18/2023 16:29:46
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AchievementObjectives")]
    public class AchievementObjective : IDataObject
    {
        public const String MODULE = "AchievementObjectives";
        public uint id;
        public uint achievementId;
        public uint order;
        public uint nameId;
        public String criterion;
    }
}