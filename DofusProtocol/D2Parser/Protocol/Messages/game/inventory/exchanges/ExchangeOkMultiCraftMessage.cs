

// Generated on 05/18/2023 15:10:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeOkMultiCraftMessage : NetworkMessage
    {
        public const uint Id = 6286;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double initiatorId;
        public double otherId;
        public sbyte role;
        
        public ExchangeOkMultiCraftMessage()
        {
        }
        
        public ExchangeOkMultiCraftMessage(double initiatorId, double otherId, sbyte role)
        {
            this.initiatorId = initiatorId;
            this.otherId = otherId;
            this.role = role;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(initiatorId);
            writer.WriteVarLong(otherId);
            writer.WriteSbyte(role);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            initiatorId = reader.ReadVarULong();
            otherId = reader.ReadVarULong();
            role = reader.ReadSbyte();
        }
        
    }
    
}