

// Generated on 05/18/2023 16:29:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AbstractSocialGroupInfos
    {
        public const short Id = 2981;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public AbstractSocialGroupInfos()
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