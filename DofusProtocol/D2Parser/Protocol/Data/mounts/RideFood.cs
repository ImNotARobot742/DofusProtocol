

// Generated on 03/23/2022 09:51:50
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