

// Generated on 03/23/2022 09:51:49
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