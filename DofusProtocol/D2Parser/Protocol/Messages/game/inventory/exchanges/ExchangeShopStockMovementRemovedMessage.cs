

// Generated on 05/18/2023 15:10:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
    {
        public const uint Id = 9139;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectId;
        
        public ExchangeShopStockMovementRemovedMessage()
        {
        }
        
        public ExchangeShopStockMovementRemovedMessage(uint objectId)
        {
            this.objectId = objectId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectId = reader.ReadVarUInt();
        }
        
    }
    
}