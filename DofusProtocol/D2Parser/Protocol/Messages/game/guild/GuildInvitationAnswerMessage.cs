

// Generated on 03/23/2022 09:50:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildInvitationAnswerMessage : NetworkMessage
    {
        public const uint Id = 8207;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool accept;
        
        public GuildInvitationAnswerMessage()
        {
        }
        
        public GuildInvitationAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            accept = reader.ReadBoolean();
        }
        
    }
    
}