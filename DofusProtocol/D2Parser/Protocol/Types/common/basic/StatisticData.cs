

// Generated on 05/18/2023 16:29:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class StatisticData
    {
        public const short Id = 8415;
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