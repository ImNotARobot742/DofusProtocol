

// Generated on 06/13/2023 16:59:52
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeReplyTaxVendorMessage : NetworkMessage
    {
        public const uint Id = 3738;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double objectValue;
        public double totalTaxValue;
        
        public ExchangeReplyTaxVendorMessage()
        {
        }
        
        public ExchangeReplyTaxVendorMessage(double objectValue, double totalTaxValue)
        {
            this.objectValue = objectValue;
            this.totalTaxValue = totalTaxValue;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(objectValue);
            writer.WriteVarLong(totalTaxValue);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectValue = reader.ReadVarULong();
            totalTaxValue = reader.ReadVarULong();
        }
        
    }
    
}