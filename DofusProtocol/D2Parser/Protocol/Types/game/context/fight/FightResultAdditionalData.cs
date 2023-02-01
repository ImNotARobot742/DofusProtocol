

// Generated on 02/01/2023 12:53:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightResultAdditionalData
    {
        public const short Id = 2708;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public FightResultAdditionalData()
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