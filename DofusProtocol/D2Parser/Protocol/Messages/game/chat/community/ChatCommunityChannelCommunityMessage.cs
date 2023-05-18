

// Generated on 05/18/2023 15:10:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatCommunityChannelCommunityMessage : NetworkMessage
    {
        public const uint Id = 7396;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short communityId;
        
        public ChatCommunityChannelCommunityMessage()
        {
        }
        
        public ChatCommunityChannelCommunityMessage(short communityId)
        {
            this.communityId = communityId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(communityId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            communityId = reader.ReadShort();
        }
        
    }
    
}