

// Generated on 06/13/2023 16:59:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyNewGuestMessage : AbstractPartyEventMessage
    {
        public const uint Id = 5374;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.PartyGuestInformations guest;
        
        public PartyNewGuestMessage()
        {
        }
        
        public PartyNewGuestMessage(uint partyId, Types.PartyGuestInformations guest)
         : base(partyId)
        {
            this.guest = guest;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            guest.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            guest = new Types.PartyGuestInformations();
            guest.Deserialize(reader);
        }
        
    }
    
}