

// Generated on 01/01/2022 14:39:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
    {
        public const uint Id = 1489;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double cancelerId;
        public double guestId;
        
        public PartyCancelInvitationNotificationMessage()
        {
        }
        
        public PartyCancelInvitationNotificationMessage(uint partyId, double cancelerId, double guestId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
            this.guestId = guestId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(cancelerId);
            writer.WriteVarLong(guestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            cancelerId = reader.ReadVarULong();
            guestId = reader.ReadVarULong();
        }
        
    }
    
}