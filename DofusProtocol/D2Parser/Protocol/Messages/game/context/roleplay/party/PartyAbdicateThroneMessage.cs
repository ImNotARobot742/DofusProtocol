

// Generated on 06/13/2023 16:59:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyAbdicateThroneMessage : AbstractPartyMessage
    {
        public const uint Id = 1518;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double playerId;
        
        public PartyAbdicateThroneMessage()
        {
        }
        
        public PartyAbdicateThroneMessage(uint partyId, double playerId)
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