

// Generated on 06/13/2023 17:00:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class Item
    {
        public const short Id = 6405;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public Item()
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