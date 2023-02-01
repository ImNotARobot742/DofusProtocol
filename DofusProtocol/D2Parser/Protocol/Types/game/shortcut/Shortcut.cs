

// Generated on 02/01/2023 12:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class Shortcut
    {
        public const short Id = 3342;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte slot;
        
        public Shortcut()
        {
        }
        
        public Shortcut(sbyte slot)
        {
            this.slot = slot;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(slot);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            slot = reader.ReadSbyte();
        }
        
    }
    
}