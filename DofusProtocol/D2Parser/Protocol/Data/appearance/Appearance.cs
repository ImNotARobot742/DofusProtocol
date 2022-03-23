

// Generated on 03/23/2022 09:51:47
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