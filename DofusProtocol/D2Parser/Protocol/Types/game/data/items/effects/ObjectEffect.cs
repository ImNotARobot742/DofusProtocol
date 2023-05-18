

// Generated on 05/18/2023 15:11:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ObjectEffect
    {
        public const short Id = 7896;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint actionId;
        
        public ObjectEffect()
        {
        }
        
        public ObjectEffect(uint actionId)
        {
            this.actionId = actionId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)actionId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            actionId = reader.ReadVarUShort();
        }
        
    }
    
}