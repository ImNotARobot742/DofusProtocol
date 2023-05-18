

// Generated on 05/18/2023 16:29:42
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Appearances")]
    public class Appearance : IDataObject
    {
        public const String MODULE = "Appearances";
        public uint id;
        public uint type;
        public String data;
    }
}