

// Generated on 05/18/2023 16:29:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeSellMessage : NetworkMessage
    {
        public const uint Id = 9235;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectToSellId;
        public uint quantity;
        
        public ExchangeSellMessage()
        {
        }
        
        public ExchangeSellMessage(uint objectToSellId, uint quantity)
        {
            this.objectToSellId = objectToSellId;
            this.quantity = quantity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectToSellId);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectToSellId = reader.ReadVarUInt();
            quantity = reader.ReadVarUInt();
        }
        
    }
    
}