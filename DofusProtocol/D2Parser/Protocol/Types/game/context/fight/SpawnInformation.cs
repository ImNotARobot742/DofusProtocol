

// Generated on 06/13/2023 17:00:03
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