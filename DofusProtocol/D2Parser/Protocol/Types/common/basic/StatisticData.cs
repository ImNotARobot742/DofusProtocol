

// Generated on 03/23/2022 09:51:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class StatisticData
    {
        public const short Id = 4316;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public StatisticData()
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