

// Generated on 05/18/2023 16:28:53
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyKickedByMessage : AbstractPartyMessage
    {
        public const uint Id = 5886;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double kickerId;
        
        public PartyKickedByMessage()
        {
        }
        
        public PartyKickedByMessage(uint partyId, double kickerId)
         : base(partyId)
        {
            this.kickerId = kickerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(kickerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            kickerId = reader.ReadVarULong();
        }
        
    }
    
}