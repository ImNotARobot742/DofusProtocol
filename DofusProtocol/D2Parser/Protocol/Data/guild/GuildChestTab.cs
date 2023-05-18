

// Generated on 05/18/2023 16:29:43
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