

// Generated on 02/01/2023 12:54:54
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