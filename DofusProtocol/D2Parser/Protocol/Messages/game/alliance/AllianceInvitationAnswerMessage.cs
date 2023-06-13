

// Generated on 06/13/2023 16:59:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceInvitationAnswerMessage : NetworkMessage
    {
        public const uint Id = 4313;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool accept;
        
        public AllianceInvitationAnswerMessage()
        {
        }
        
        public AllianceInvitationAnswerMessage(bool accept)
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