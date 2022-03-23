

// Generated on 03/23/2022 09:51:50
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