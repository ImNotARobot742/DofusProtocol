

// Generated on 05/18/2023 16:28:53
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyInvitationMessage : AbstractPartyMessage
    {
        public const uint Id = 9994;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte partyType;
        public string partyName;
        public sbyte maxParticipants;
        public double fromId;
        public string fromName;
        public double toId;
        
        public PartyInvitationMessage()
        {
        }
        
        public PartyInvitationMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, double fromId, string fromName, double toId)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyName = partyName;
            this.maxParticipants = maxParticipants;
            this.fromId = fromId;
            this.fromName = fromName;
            this.toId = toId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(partyType);
            writer.WriteUTF(partyName);
            writer.WriteSbyte(maxParticipants);
            writer.WriteVarLong(fromId);
            writer.WriteUTF(fromName);
            writer.WriteVarLong(toId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            partyType = reader.ReadSbyte();
            partyName = reader.ReadUTF();
            maxParticipants = reader.ReadSbyte();
            fromId = reader.ReadVarULong();
            fromName = reader.ReadUTF();
            toId = reader.ReadVarULong();
        }
        
    }
    
}