

// Generated on 05/18/2023 16:29:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartOkNpcTradeMessage : NetworkMessage
    {
        public const uint Id = 7647;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double npcId;
        
        public ExchangeStartOkNpcTradeMessage()
        {
        }
        
        public ExchangeStartOkNpcTradeMessage(double npcId)
        {
            this.npcId = npcId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(npcId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            npcId = reader.ReadDouble();
        }
        
    }
    
}