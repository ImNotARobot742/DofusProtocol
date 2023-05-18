

// Generated on 05/18/2023 16:29:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeReplayStopMessage : NetworkMessage
    {
        public const uint Id = 224;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ExchangeReplayStopMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}