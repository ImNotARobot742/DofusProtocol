

// Generated on 06/13/2023 16:59:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatCommunityChannelSetCommunityRequestMessage : NetworkMessage
    {
        public const uint Id = 539;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short communityId;
        
        public ChatCommunityChannelSetCommunityRequestMessage()
        {
        }
        
        public ChatCommunityChannelSetCommunityRequestMessage(short communityId)
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