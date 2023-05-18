

// Generated on 05/18/2023 15:11:05
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