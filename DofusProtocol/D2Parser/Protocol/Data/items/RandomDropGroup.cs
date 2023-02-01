

// Generated on 02/01/2023 12:54:52
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