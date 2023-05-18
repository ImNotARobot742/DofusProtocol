

// Generated on 05/18/2023 15:10:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ArenaRankInfos
    {
        public const short Id = 834;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public Types.ArenaRanking ranking;
        public Types.ArenaLeagueRanking leagueRanking;
        public uint victoryCount;
        public uint fightcount;
        public short numFightNeededForLadder;
        
        public ArenaRankInfos()
        {
        }
        
        public ArenaRankInfos(Types.ArenaRanking ranking, Types.ArenaLeagueRanking leagueRanking, uint victoryCount, uint fightcount, short numFightNeededForLadder)
        {
            this.ranking = ranking;
            this.leagueRanking = leagueRanking;
            this.victoryCount = victoryCount;
            this.fightcount = fightcount;
            this.numFightNeededForLadder = numFightNeededForLadder;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            ranking.Serialize(writer);
            leagueRanking.Serialize(writer);
            writer.WriteVarShort((short)victoryCount);
            writer.WriteVarShort((short)fightcount);
            writer.WriteShort(numFightNeededForLadder);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            ranking = new Types.ArenaRanking();
            ranking.Deserialize(reader);
            leagueRanking = new Types.ArenaLeagueRanking();
            leagueRanking.Deserialize(reader);
            victoryCount = reader.ReadVarUShort();
            fightcount = reader.ReadVarUShort();
            numFightNeededForLadder = reader.ReadShort();
        }
        
    }
    
}