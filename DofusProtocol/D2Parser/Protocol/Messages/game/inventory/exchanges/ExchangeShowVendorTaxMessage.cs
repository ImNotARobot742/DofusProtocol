

// Generated on 02/01/2023 12:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeShowVendorTaxMessage : NetworkMessage
    {
        public const uint Id = 8420;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ExchangeShowVendorTaxMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}