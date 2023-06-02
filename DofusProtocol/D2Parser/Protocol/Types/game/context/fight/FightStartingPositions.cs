

// Generated on 06/02/2023 19:01:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightStartingPositions
    {
        public const short Id = 11;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint[] positionsForChallengers;
        public uint[] positionsForDefenders;
        
        public FightStartingPositions()
        {
        }
        
        public FightStartingPositions(uint[] positionsForChallengers, uint[] positionsForDefenders)
        {
            this.positionsForChallengers = positionsForChallengers;
            this.positionsForDefenders = positionsForDefenders;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)positionsForChallengers.Length);
            foreach (var entry in positionsForChallengers)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)positionsForDefenders.Length);
            foreach (var entry in positionsForDefenders)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            positionsForChallengers = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForChallengers[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            positionsForDefenders = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForDefenders[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}