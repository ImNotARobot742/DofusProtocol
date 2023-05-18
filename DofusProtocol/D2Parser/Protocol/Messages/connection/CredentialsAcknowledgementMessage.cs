

// Generated on 05/18/2023 15:10:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CredentialsAcknowledgementMessage : NetworkMessage
    {
        public const uint Id = 9170;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public CredentialsAcknowledgementMessage()
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