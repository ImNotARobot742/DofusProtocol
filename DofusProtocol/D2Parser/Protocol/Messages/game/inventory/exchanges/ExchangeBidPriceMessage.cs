

// Generated on 02/01/2023 12:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidPriceMessage : NetworkMessage
    {
        public const uint Id = 4385;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint genericId;
        public double averagePrice;
        
        public ExchangeBidPriceMessage()
        {
        }
        
        public ExchangeBidPriceMessage(uint genericId, double averagePrice)
        {
            this.genericId = genericId;
            this.averagePrice = averagePrice;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)genericId);
            writer.WriteVarLong(averagePrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            genericId = reader.ReadVarUShort();
            averagePrice = reader.ReadVarLong();
        }
        
    }
    
}