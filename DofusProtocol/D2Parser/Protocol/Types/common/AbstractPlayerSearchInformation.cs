

// Generated on 06/02/2023 19:01:12
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AbstractPlayerSearchInformation
    {
        public const short Id = 4733;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public AbstractPlayerSearchInformation()
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