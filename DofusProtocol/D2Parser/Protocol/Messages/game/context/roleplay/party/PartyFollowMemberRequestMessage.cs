

// Generated on 02/01/2023 12:53:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyFollowMemberRequestMessage : AbstractPartyMessage
    {
        public const uint Id = 9093;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double playerId;
        
        public PartyFollowMemberRequestMessage()
        {
        }
        
        public PartyFollowMemberRequestMessage(uint partyId, double playerId)
         : base(partyId)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarULong();
        }
        
    }
    
}