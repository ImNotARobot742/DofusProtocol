

// Generated on 06/02/2023 19:00:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeObjectUseInWorkshopMessage : NetworkMessage
    {
        public const uint Id = 2573;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        public int quantity;
        
        public ExchangeObjectUseInWorkshopMessage()
        {
        }
        
        public ExchangeObjectUseInWorkshopMessage(uint objectUID, int quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectUID = reader.ReadVarUInt();
            quantity = reader.ReadVarInt();
        }
        
    }
    
}