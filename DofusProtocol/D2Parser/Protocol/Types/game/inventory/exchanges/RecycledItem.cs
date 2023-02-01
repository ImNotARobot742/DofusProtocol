

// Generated on 02/01/2023 12:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class RecycledItem
    {
        public const short Id = 2393;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        public uint qty;
        
        public RecycledItem()
        {
        }
        
        public RecycledItem(uint id, uint qty)
        {
            this.id = id;
            this.qty = qty;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)id);
            writer.WriteUInt(qty);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUShort();
            qty = reader.ReadUInt();
        }
        
    }
    
}