

// Generated on 02/01/2023 12:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyRefuseInvitationMessage : AbstractPartyMessage
    {
        public const uint Id = 5526;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PartyRefuseInvitationMessage()
        {
        }
        
        public PartyRefuseInvitationMessage(uint partyId)
         : base(partyId)
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