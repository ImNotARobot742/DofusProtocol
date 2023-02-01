

// Generated on 02/01/2023 12:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GoldItem : Item
    {
        public const short Id = 7805;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double sum;
        
        public GoldItem()
        {
        }
        
        public GoldItem(double sum)
        {
            this.sum = sum;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(sum);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            sum = reader.ReadVarULong();
        }
        
    }
    
}