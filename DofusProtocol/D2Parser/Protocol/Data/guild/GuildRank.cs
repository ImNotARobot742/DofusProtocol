

// Generated on 06/02/2023 19:01:29
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("GuildRanks")]
    public class GuildRank : IDataObject
    {
        public const String MODULE = "GuildRanks";
        public int id;
        public uint nameId;
        public int order;
        public Boolean isModifiable;
        public uint gfxId;
    }
}