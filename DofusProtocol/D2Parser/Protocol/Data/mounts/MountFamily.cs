

// Generated on 06/13/2023 17:00:13
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MountFamily")]
    public class MountFamily : IDataObject
    {
        private const String MODULE = "MountFamily";
        public uint id;
        public uint nameId;
        public String headUri;
    }
}