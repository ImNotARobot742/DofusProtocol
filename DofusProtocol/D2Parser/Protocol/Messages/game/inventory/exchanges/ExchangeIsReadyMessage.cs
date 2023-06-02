

// Generated on 06/02/2023 19:00:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeIsReadyMessage : NetworkMessage
    {
        public const uint Id = 8363;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double id;
        public bool ready;
        
        public ExchangeIsReadyMessage()
        {
        }
        
        public ExchangeIsReadyMessage(double id, bool ready)
        {
            this.id = id;
            this.ready = ready;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(id);
            writer.WriteBoolean(ready);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            id = reader.ReadDouble();
            ready = reader.ReadBoolean();
        }
        
    }
    
}