

// Generated on 06/02/2023 19:01:32
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