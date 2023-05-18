

// Generated on 05/18/2023 15:10:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeObjectMessage : NetworkMessage
    {
        public const uint Id = 2941;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool remote;
        
        public ExchangeObjectMessage()
        {
        }
        
        public ExchangeObjectMessage(bool remote)
        {
            this.remote = remote;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(remote);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            remote = reader.ReadBoolean();
        }
        
    }
    
}