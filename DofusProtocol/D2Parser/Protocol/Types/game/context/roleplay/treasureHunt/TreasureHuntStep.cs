

// Generated on 06/13/2023 17:00:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TreasureHuntStep
    {
        public const short Id = 8385;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public TreasureHuntStep()
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