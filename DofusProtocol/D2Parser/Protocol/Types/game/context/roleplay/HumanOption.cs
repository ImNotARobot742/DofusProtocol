

// Generated on 01/01/2022 14:40:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class HumanOption
    {
        public const short Id = 693;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public HumanOption()
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