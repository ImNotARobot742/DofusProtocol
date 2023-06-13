

// Generated on 06/13/2023 17:00:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class EntityInformation
    {
        public const short Id = 1392;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        public uint experience;
        public bool status;
        
        public EntityInformation()
        {
        }
        
        public EntityInformation(uint id, uint experience, bool status)
        {
            this.id = id;
            this.experience = experience;
            this.status = status;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)id);
            writer.WriteVarInt((int)experience);
            writer.WriteBoolean(status);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUShort();
            experience = reader.ReadVarUInt();
            status = reader.ReadBoolean();
        }
        
    }
    
}