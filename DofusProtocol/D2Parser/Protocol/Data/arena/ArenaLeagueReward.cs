

// Generated on 05/18/2023 15:11:04
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