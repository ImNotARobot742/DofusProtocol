

// Generated on 01/01/2022 14:39:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangePodsModifiedMessage : ExchangeObjectMessage
    {
        public const uint Id = 7130;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint currentWeight;
        public uint maxWeight;
        
        public ExchangePodsModifiedMessage()
        {
        }
        
        public ExchangePodsModifiedMessage(bool remote, uint currentWeight, uint maxWeight)
         : base(remote)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)currentWeight);
            writer.WriteVarInt((int)maxWeight);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            currentWeight = reader.ReadVarUInt();
            maxWeight = reader.ReadVarUInt();
        }
        
    }
    
}