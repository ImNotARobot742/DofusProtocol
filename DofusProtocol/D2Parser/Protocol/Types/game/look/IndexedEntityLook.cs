

// Generated on 05/18/2023 15:11:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class IndexedEntityLook
    {
        public const short Id = 5803;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public Types.EntityLook look;
        public sbyte index;
        
        public IndexedEntityLook()
        {
        }
        
        public IndexedEntityLook(Types.EntityLook look, sbyte index)
        {
            this.look = look;
            this.index = index;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            look.Serialize(writer);
            writer.WriteSbyte(index);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            look = new Types.EntityLook();
            look.Deserialize(reader);
            index = reader.ReadSbyte();
        }
        
    }
    
}