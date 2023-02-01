

// Generated on 02/01/2023 12:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildMotdMessage : SocialNoticeMessage
    {
        public const uint Id = 5546;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GuildMotdMessage()
        {
        }
        
        public GuildMotdMessage(string content, int timestamp, double memberId, string memberName)
         : base(content, timestamp, memberId, memberName)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}