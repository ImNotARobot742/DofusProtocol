

// Generated on 05/18/2023 15:11:07
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Modsters")]
    public class Modster : IDataObject
    {
        public const String MODULE = "Modsters";
        public int id;
        public int itemId;
        public int modsterId;
        public int order;
        public List<int> parentsModsterId;
        public List<int> modsterActiveSpells;
        public List<int> modsterPassiveSpells;
        public List<int> modsterHiddenAchievements;
        public List<int> modsterAchievements;
    }
}