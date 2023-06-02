

// Generated on 06/02/2023 19:00:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeCraftCountModifiedMessage : NetworkMessage
    {
        public const uint Id = 674;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int count;
        
        public ExchangeCraftCountModifiedMessage()
        {
        }
        
        public ExchangeCraftCountModifiedMessage(int count)
        {
            this.count = count;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)count);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            count = reader.ReadVarInt();
        }
        
    }
    
}