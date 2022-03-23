

// Generated on 03/23/2022 09:51:50
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