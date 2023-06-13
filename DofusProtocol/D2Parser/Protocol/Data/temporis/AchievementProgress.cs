

// Generated on 06/13/2023 17:00:14
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AchievementProgress")]
    public class AchievementProgress : IDataObject
    {
        public const String MODULE = "AchievementProgress";
        public int id;
        public String name;
        public int seasonId;
    }
}