

// Generated on 05/18/2023 15:11:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class Preset
    {
        public const short Id = 2869;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public short id;
        
        public Preset()
        {
        }
        
        public Preset(short id)
        {
            this.id = id;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort(id);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadShort();
        }
        
    }
    
}