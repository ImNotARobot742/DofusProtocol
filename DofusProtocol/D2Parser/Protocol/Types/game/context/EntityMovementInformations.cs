

// Generated on 01/01/2022 14:40:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class EntityMovementInformations
    {
        public const short Id = 7283;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int id;
        public sbyte[] steps;
        
        public EntityMovementInformations()
        {
        }
        
        public EntityMovementInformations(int id, sbyte[] steps)
        {
            this.id = id;
            this.steps = steps;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(id);
            writer.WriteVarInt((int)(ushort)steps.Length);
            foreach (var entry in steps)
            {
                 writer.WriteSbyte(entry);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadInt();
            var limit = (ushort)reader.ReadVarInt();
            steps = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 steps[i] = reader.ReadSbyte();
            }
        }
        
    }
    
}