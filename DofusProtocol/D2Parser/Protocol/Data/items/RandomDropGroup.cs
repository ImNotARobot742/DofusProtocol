

// Generated on 05/18/2023 16:29:44
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("RandomDropGroups")]
    public class RandomDropGroup : IDataObject
    {
        public const String MODULE = "RandomDropGroups";
        public uint id;
        public String name;
        public String description;
        public List<RandomDropItem> randomDropItems;
        public Boolean displayContent;
        public Boolean displayChances;
    }
}