

// Generated on 03/23/2022 09:51:48
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("NamingRules")]
    public class NamingRule : IDataObject
    {
        public const String MODULE = "NamingRules";
        public uint id;
        public uint minLength;
        public uint maxLength;
        public String regexp;
    }
}