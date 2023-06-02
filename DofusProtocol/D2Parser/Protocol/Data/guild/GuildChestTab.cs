

// Generated on 06/02/2023 19:01:29
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("GuildChestTabs")]
    public class GuildChestTab : IDataObject
    {
        public const String MODULE = "GuildChestTabs";
        public int tabId;
        public uint nameId;
        public uint index;
        public uint gfxId;
        public int serverType;
        public uint cost;
        public uint seniority;
        public uint openRight;
        public uint dropRight;
        public uint takeRight;
    }
}