

// Generated on 06/13/2023 17:00:11
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("GuildRights")]
    public class GuildRight : IDataObject
    {
        public const String MODULE = "GuildRights";
        public int id;
        public uint nameId;
        public int order;
        public int groupId;
    }
}