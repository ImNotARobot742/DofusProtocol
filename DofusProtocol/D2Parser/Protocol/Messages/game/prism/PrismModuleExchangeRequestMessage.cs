

// Generated on 06/13/2023 16:59:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismModuleExchangeRequestMessage : NetworkMessage
    {
        public const uint Id = 3363;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PrismModuleExchangeRequestMessage()
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