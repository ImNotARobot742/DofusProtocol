

// Generated on 06/02/2023 19:00:43
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