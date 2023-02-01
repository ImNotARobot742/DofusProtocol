

// Generated on 02/01/2023 12:54:51
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