

// Generated on 06/13/2023 16:59:52
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeRequestMessage : NetworkMessage
    {
        public const uint Id = 7691;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte exchangeType;
        
        public ExchangeRequestMessage()
        {
        }
        
        public ExchangeRequestMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(exchangeType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            exchangeType = reader.ReadSbyte();
        }
        
    }
    
}