

// Generated on 03/23/2022 09:51:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ServerSessionConstant
    {
        public const short Id = 9635;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        
        public ServerSessionConstant()
        {
        }
        
        public ServerSessionConstant(uint id)
        {
            this.id = id;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)id);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUShort();
        }
        
    }
    
}