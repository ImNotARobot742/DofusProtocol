

// Generated on 02/01/2023 12:53:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class EditHavenBagRequestMessage : NetworkMessage
    {
        public const uint Id = 9425;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public EditHavenBagRequestMessage()
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