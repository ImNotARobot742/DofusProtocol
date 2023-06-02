

// Generated on 06/02/2023 19:01:28
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