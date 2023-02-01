

// Generated on 02/01/2023 12:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeWeightMessage : NetworkMessage
    {
        public const uint Id = 1225;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint currentWeight;
        public uint maxWeight;
        
        public ExchangeWeightMessage()
        {
        }
        
        public ExchangeWeightMessage(uint currentWeight, uint maxWeight)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)currentWeight);
            writer.WriteVarInt((int)maxWeight);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            currentWeight = reader.ReadVarUInt();
            maxWeight = reader.ReadVarUInt();
        }
        
    }
    
}