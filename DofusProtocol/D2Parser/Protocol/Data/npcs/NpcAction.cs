

// Generated on 06/02/2023 19:01:31
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("NpcActions")]
    public class NpcAction : IDataObject
    {
        public const String MODULE = "NpcActions";
        public int id;
        public int realId;
        public uint nameId;
    }
}