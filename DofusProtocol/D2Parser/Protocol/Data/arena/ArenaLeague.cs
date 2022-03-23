

// Generated on 03/23/2022 09:51:47
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