

// Generated on 02/01/2023 12:53:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyLocateMembersRequestMessage : AbstractPartyMessage
    {
        public const uint Id = 3969;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PartyLocateMembersRequestMessage()
        {
        }
        
        public PartyLocateMembersRequestMessage(uint partyId)
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