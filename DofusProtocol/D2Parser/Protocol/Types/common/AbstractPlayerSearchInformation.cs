

// Generated on 02/01/2023 12:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AbstractPlayerSearchInformation
    {
        public const short Id = 4580;
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