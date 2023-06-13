

// Generated on 06/13/2023 17:00:13
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