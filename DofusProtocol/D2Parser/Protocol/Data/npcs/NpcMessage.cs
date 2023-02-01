

// Generated on 02/01/2023 12:54:54
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("NpcMessages")]
    public class NpcMessage : IDataObject
    {
        public const String MODULE = "NpcMessages";
        public int id;
        public uint messageId;
        public List<String> messageParams;
    }
}