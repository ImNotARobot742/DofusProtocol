

// Generated on 02/01/2023 12:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartOkRecycleTradeMessage : NetworkMessage
    {
        public const uint Id = 6635;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short percentToPrism;
        public short percentToPlayer;
        
        public ExchangeStartOkRecycleTradeMessage()
        {
        }
        
        public ExchangeStartOkRecycleTradeMessage(short percentToPrism, short percentToPlayer)
        {
            this.percentToPrism = percentToPrism;
            this.percentToPlayer = percentToPlayer;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(percentToPrism);
            writer.WriteShort(percentToPlayer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            percentToPrism = reader.ReadShort();
            percentToPlayer = reader.ReadShort();
        }
        
    }
    
}