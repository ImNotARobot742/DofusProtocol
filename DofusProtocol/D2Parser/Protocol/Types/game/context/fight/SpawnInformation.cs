

// Generated on 05/18/2023 15:10:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SpawnInformation
    {
        public const short Id = 8609;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public SpawnInformation()
        {
        }
        
        
        public virtual void Serialize(IDataWriter writer)
        {
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}