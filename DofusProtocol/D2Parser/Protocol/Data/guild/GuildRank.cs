

// Generated on 02/01/2023 12:54:51
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