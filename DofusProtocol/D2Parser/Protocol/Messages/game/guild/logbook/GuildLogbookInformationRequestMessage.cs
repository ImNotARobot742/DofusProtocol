

// Generated on 06/13/2023 16:59:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildLogbookInformationRequestMessage : NetworkMessage
    {
        public const uint Id = 9151;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GuildLogbookInformationRequestMessage()
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