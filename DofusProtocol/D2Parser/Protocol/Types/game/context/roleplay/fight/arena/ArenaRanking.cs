

// Generated on 03/23/2022 09:51:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ArenaRanking
    {
        public const short Id = 3975;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint rank;
        public uint bestRank;
        
        public ArenaRanking()
        {
        }
        
        public ArenaRanking(uint rank, uint bestRank)
        {
            this.rank = rank;
            this.bestRank = bestRank;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)rank);
            writer.WriteVarShort((short)bestRank);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            rank = reader.ReadVarUShort();
            bestRank = reader.ReadVarUShort();
        }
        
    }
    
}