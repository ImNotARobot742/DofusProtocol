

// Generated on 05/18/2023 16:29:46
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Achievements")]
    public class Achievement : IDataObject
    {
        public const String MODULE = "Achievements";
        public double _totalAchievementPoints = float.NaN;
        public uint id;
        public uint nameId;
        public uint categoryId;
        public uint descriptionId;
        public int iconId;
        public uint points;
        public uint level;
        public uint order;
        public Boolean accountLinked;
        public List<int> objectiveIds;
        public List<int> rewardIds;
    }
}