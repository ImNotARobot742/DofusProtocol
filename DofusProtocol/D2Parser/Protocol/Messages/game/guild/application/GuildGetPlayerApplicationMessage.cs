

// Generated on 02/01/2023 12:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildGetPlayerApplicationMessage : NetworkMessage
    {
        public const uint Id = 5389;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GuildGetPlayerApplicationMessage()
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