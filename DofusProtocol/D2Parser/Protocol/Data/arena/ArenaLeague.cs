

// Generated on 06/13/2023 17:00:10
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ArenaLeagues")]
    public class ArenaLeague : IDataObject
    {
        public const String MODULE = "ArenaLeagues";
        public int id;
        public uint nameId;
        public uint ornamentId;
        public String icon;
        public String illus;
        public Boolean isLastLeague;
    }
}