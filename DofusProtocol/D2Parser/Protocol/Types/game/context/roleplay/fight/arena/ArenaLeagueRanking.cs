

// Generated on 05/18/2023 15:10:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ArenaLeagueRanking
    {
        public const short Id = 1120;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint rank;
        public uint leagueId;
        public int leaguePoints;
        public int totalLeaguePoints;
        public int ladderPosition;
        
        public ArenaLeagueRanking()
        {
        }
        
        public ArenaLeagueRanking(uint rank, uint leagueId, int leaguePoints, int totalLeaguePoints, int ladderPosition)
        {
            this.rank = rank;
            this.leagueId = leagueId;
            this.leaguePoints = leaguePoints;
            this.totalLeaguePoints = totalLeaguePoints;
            this.ladderPosition = ladderPosition;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)rank);
            writer.WriteVarShort((short)leagueId);
            writer.WriteVarShort((short)leaguePoints);
            writer.WriteVarShort((short)totalLeaguePoints);
            writer.WriteInt(ladderPosition);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            rank = reader.ReadVarUShort();
            leagueId = reader.ReadVarUShort();
            leaguePoints = reader.ReadVarShort();
            totalLeaguePoints = reader.ReadVarShort();
            ladderPosition = reader.ReadInt();
        }
        
    }
    
}