

// Generated on 01/01/2022 14:39:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachInvitationAnswerMessage : NetworkMessage
    {
        public const uint Id = 5975;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool accept;
        
        public BreachInvitationAnswerMessage()
        {
        }
        
        public BreachInvitationAnswerMessage(bool accept)
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