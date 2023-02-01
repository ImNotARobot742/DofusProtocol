

// Generated on 02/01/2023 12:54:50
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ArenaLeagueRewards")]
    public class ArenaLeagueReward : IDataObject
    {
        public const String MODULE = "ArenaLeagueRewards";
        public int id;
        public uint seasonId;
        public uint leagueId;
        public List<uint> titlesRewards;
        public Boolean endSeasonRewards;
    }
}