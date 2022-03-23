

// Generated on 03/23/2022 09:51:47
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AlignmentRank")]
    public class AlignmentRank : IDataObject
    {
        public const String MODULE = "AlignmentRank";
        public int id;
        public uint orderId;
        public uint nameId;
        public uint descriptionId;
        public int minimumAlignment;
        public List<int> gifts;
    }
}