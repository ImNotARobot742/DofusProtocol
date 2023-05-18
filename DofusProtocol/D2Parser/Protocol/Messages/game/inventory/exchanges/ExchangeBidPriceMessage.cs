

// Generated on 05/18/2023 16:29:03
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
        public const uint Id = 4446;
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
            writer.WriteVarInt((int)genericId);
            writer.WriteVarLong(averagePrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            genericId = reader.ReadVarUInt();
            averagePrice = reader.ReadVarLong();
        }
        
    }
    
}