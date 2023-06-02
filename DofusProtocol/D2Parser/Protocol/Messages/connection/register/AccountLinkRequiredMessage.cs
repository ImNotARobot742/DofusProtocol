

// Generated on 06/02/2023 19:00:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AccountLinkRequiredMessage : NetworkMessage
    {
        public const uint Id = 4741;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AccountLinkRequiredMessage()
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