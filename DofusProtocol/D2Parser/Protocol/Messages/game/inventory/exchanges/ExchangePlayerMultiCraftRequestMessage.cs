

// Generated on 06/13/2023 16:59:52
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangePlayerMultiCraftRequestMessage : ExchangeRequestMessage
    {
        public const uint Id = 600;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double target;
        public uint skillId;
        
        public ExchangePlayerMultiCraftRequestMessage()
        {
        }
        
        public ExchangePlayerMultiCraftRequestMessage(sbyte exchangeType, double target, uint skillId)
         : base(exchangeType)
        {
            this.target = target;
            this.skillId = skillId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(target);
            writer.WriteVarInt((int)skillId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            target = reader.ReadVarULong();
            skillId = reader.ReadVarUInt();
        }
        
    }
    
}