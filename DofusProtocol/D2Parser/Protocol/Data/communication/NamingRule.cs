

// Generated on 05/18/2023 16:29:43
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