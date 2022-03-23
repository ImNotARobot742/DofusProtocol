

// Generated on 03/23/2022 09:50:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildInvitationMessage : NetworkMessage
    {
        public const uint Id = 2174;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        
        public GuildInvitationMessage()
        {
        }
        
        public GuildInvitationMessage(double targetId)
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