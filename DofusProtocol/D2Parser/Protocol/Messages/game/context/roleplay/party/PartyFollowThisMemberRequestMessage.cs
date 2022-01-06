

// Generated on 01/01/2022 14:39:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyFollowThisMemberRequestMessage : PartyFollowMemberRequestMessage
    {
        public const uint Id = 4755;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool enabled;
        
        public PartyFollowThisMemberRequestMessage()
        {
        }
        
        public PartyFollowThisMemberRequestMessage(uint partyId, double playerId, bool enabled)
         : base(partyId, playerId)
        {
            this.enabled = enabled;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(enabled);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            enabled = reader.ReadBoolean();
        }
        
    }
    
}