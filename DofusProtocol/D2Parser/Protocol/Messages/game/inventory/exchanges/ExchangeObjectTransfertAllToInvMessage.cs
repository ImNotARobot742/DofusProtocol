

// Generated on 03/23/2022 09:50:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeObjectTransfertAllToInvMessage : NetworkMessage
    {
        public const uint Id = 7461;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ExchangeObjectTransfertAllToInvMessage()
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