

// Generated on 02/01/2023 12:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AbstractCharacterInformation
    {
        public const short Id = 776;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double id;
        
        public AbstractCharacterInformation()
        {
        }
        
        public AbstractCharacterInformation(double id)
        {
            this.id = id;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(id);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarULong();
        }
        
    }
    
}