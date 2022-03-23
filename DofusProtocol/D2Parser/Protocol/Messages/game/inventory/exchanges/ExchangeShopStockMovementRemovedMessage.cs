

// Generated on 03/23/2022 09:50:37
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
        public const uint Id = 7314;
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