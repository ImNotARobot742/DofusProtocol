

// Generated on 06/13/2023 16:59:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyUpdateMessage : AbstractPartyEventMessage
    {
        public const uint Id = 6279;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.PartyMemberInformations memberInformations;
        
        public PartyUpdateMessage()
        {
        }
        
        public PartyUpdateMessage(uint partyId, Types.PartyMemberInformations memberInformations)
         : base(partyId)
        {
            this.memberInformations = memberInformations;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(memberInformations.TypeId);
            memberInformations.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            memberInformations = ProtocolTypeManager.GetInstance<Types.PartyMemberInformations>(reader.ReadUShort());
            memberInformations.Deserialize(reader);
        }
        
    }
    
}