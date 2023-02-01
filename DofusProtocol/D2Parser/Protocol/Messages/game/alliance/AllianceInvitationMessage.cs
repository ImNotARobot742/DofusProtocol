

// Generated on 02/01/2023 12:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceInvitationMessage : NetworkMessage
    {
        public const uint Id = 9860;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        
        public AllianceInvitationMessage()
        {
        }
        
        public AllianceInvitationMessage(double targetId)
        {
            this.targetId = targetId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            targetId = reader.ReadVarULong();
        }
        
    }
    
}