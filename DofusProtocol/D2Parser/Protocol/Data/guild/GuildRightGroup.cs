

// Generated on 02/01/2023 12:54:51
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("GuildRightGroups")]
    public class GuildRightGroup : IDataObject
    {
        public const String MODULE = "GuildRightGroups";
        public int id;
        public uint nameId;
        public int order;
        public List<GuildRight> guildRights;
    }
}