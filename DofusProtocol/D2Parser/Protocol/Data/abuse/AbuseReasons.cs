

// Generated on 03/23/2022 09:51:47
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AbuseReasons")]
    public class AbuseReasons : IDataObject
    {
        public const String MODULE = "AbuseReasons";
        public uint abuseReasonId;
        public uint mask;
        public int reasonTextId;
    }
}