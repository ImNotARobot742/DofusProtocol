

// Generated on 06/13/2023 17:00:09
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