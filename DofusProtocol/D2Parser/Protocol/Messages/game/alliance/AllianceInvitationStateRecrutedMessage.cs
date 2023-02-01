

// Generated on 02/01/2023 12:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceInvitationStateRecrutedMessage : NetworkMessage
    {
        public const uint Id = 9943;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte invitationState;
        
        public AllianceInvitationStateRecrutedMessage()
        {
        }
        
        public AllianceInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(invitationState);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            invitationState = reader.ReadSbyte();
        }
        
    }
    
}