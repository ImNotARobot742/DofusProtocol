

// Generated on 03/23/2022 09:51:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PaddockInformations
    {
        public const short Id = 5079;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint maxOutdoorMount;
        public uint maxItems;
        
        public PaddockInformations()
        {
        }
        
        public PaddockInformations(uint maxOutdoorMount, uint maxItems)
        {
            this.maxOutdoorMount = maxOutdoorMount;
            this.maxItems = maxItems;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)maxOutdoorMount);
            writer.WriteVarShort((short)maxItems);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            maxOutdoorMount = reader.ReadVarUShort();
            maxItems = reader.ReadVarUShort();
        }
        
    }
    
}