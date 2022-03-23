

// Generated on 03/23/2022 09:51:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SpawnInformation
    {
        public const short Id = 7022;
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