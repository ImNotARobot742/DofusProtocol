

// Generated on 05/18/2023 15:11:07
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("RideFood")]
    public class RideFood : IDataObject
    {
        public String MODULE = "RideFood";
        public uint gid;
        public uint typeId;
        public uint familyId;
    }
}