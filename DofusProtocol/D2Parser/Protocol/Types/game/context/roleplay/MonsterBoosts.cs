

// Generated on 05/18/2023 16:29:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class MonsterBoosts
    {
        public const short Id = 6739;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        public uint xpBoost;
        public uint dropBoost;
        
        public MonsterBoosts()
        {
        }
        
        public MonsterBoosts(uint id, uint xpBoost, uint dropBoost)
        {
            this.id = id;
            this.xpBoost = xpBoost;
            this.dropBoost = dropBoost;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)id);
            writer.WriteVarShort((short)xpBoost);
            writer.WriteVarShort((short)dropBoost);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUInt();
            xpBoost = reader.ReadVarUShort();
            dropBoost = reader.ReadVarUShort();
        }
        
    }
    
}