

// Generated on 05/18/2023 15:10:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SocialNoticeSetRequestMessage : NetworkMessage
    {
        public const uint Id = 5359;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public SocialNoticeSetRequestMessage()
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