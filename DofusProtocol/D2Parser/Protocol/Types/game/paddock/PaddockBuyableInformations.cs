

// Generated on 02/01/2023 12:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PaddockBuyableInformations
    {
        public const short Id = 1474;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double price;
        public bool locked;
        
        public PaddockBuyableInformations()
        {
        }
        
        public PaddockBuyableInformations(double price, bool locked)
        {
            this.price = price;
            this.locked = locked;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(price);
            writer.WriteBoolean(locked);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            price = reader.ReadVarULong();
            locked = reader.ReadBoolean();
        }
        
    }
    
}