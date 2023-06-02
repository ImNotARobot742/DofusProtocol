

// Generated on 06/02/2023 19:01:29
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("GuildTags")]
    public class GuildTag : IDataObject
    {
        public const String MODULE = "GuildTags";
        public int id;
        public int typeId;
        public uint nameId;
        public int order;
        public GuildTagsType type;
    }
}