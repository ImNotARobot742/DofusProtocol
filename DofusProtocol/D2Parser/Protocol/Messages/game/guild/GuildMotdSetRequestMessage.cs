

// Generated on 06/13/2023 16:59:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildMotdSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public const uint Id = 9078;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string content;
        
        public GuildMotdSetRequestMessage()
        {
        }
        
        public GuildMotdSetRequestMessage(string content)
        {
            this.content = content;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(content);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            content = reader.ReadUTF();
        }
        
    }
    
}