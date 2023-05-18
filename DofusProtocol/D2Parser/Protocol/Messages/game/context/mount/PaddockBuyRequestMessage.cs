

// Generated on 05/18/2023 16:28:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaddockBuyRequestMessage : NetworkMessage
    {
        public const uint Id = 9739;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double proposedPrice;
        
        public PaddockBuyRequestMessage()
        {
        }
        
        public PaddockBuyRequestMessage(double proposedPrice)
        {
            this.proposedPrice = proposedPrice;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(proposedPrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            proposedPrice = reader.ReadVarULong();
        }
        
    }
    
}