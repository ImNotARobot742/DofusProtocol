

// Generated on 01/01/2022 14:39:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AbstractPlayerSearchInformation
    {
        public const short Id = 1294;
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