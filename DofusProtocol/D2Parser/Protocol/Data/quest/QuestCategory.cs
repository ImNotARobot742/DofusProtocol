

// Generated on 06/13/2023 17:00:13
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("QuestCategory")]
    public class QuestCategory : IDataObject
    {
        public const String MODULE = "QuestCategory";
        public uint id;
        public uint nameId;
        public uint order;
        public List<uint> questIds;
    }
}