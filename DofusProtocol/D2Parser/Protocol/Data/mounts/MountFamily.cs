

// Generated on 02/01/2023 12:54:53
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