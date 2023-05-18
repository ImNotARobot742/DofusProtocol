

// Generated on 05/18/2023 16:29:44
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("VeteranRewards")]
    public class VeteranReward : IDataObject
    {
        public const String MODULE = "VeteranRewards";
        public int id;
        public uint requiredSubDays;
        public uint itemGID;
        public uint itemQuantity;
    }
}