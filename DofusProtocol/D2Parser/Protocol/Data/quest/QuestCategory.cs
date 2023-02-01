

// Generated on 02/01/2023 12:54:54
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