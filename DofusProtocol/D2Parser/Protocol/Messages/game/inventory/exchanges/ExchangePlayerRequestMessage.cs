

// Generated on 05/18/2023 15:10:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangePlayerRequestMessage : ExchangeRequestMessage
    {
        public const uint Id = 9205;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double target;
        
        public ExchangePlayerRequestMessage()
        {
        }
        
        public ExchangePlayerRequestMessage(sbyte exchangeType, double target)
         : base(exchangeType)
        {
            this.target = target;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(target);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            target = reader.ReadVarULong();
        }
        
    }
    
}