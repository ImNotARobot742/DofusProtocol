

// Generated on 05/18/2023 15:11:07
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AchievementCategories")]
    public class AchievementCategory : IDataObject
    {
        public const String MODULE = "AchievementCategories";
        public uint id;
        public uint nameId;
        public uint parentId;
        public String icon;
        public uint order;
        public String color;
        public List<uint> achievementIds;
        public String visibilityCriterion;
    }
}