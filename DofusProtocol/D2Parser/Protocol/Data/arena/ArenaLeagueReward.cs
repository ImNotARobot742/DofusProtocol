

// Generated on 03/23/2022 09:51:47
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