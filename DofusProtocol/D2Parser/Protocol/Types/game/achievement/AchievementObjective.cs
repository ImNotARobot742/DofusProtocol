

// Generated on 02/01/2023 12:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AchievementObjective
    {
        public const short Id = 6663;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        public uint maxValue;
        
        public AchievementObjective()
        {
        }
        
        public AchievementObjective(uint id, uint maxValue)
        {
            this.id = id;
            this.maxValue = maxValue;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)id);
            writer.WriteVarShort((short)maxValue);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUInt();
            maxValue = reader.ReadVarUShort();
        }
        
    }
    
}