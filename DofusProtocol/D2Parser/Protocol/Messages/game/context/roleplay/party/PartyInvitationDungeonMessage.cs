

// Generated on 06/13/2023 16:59:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyInvitationDungeonMessage : PartyInvitationMessage
    {
        public const uint Id = 947;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        
        public PartyInvitationDungeonMessage()
        {
        }
        
        public PartyInvitationDungeonMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, double fromId, string fromName, double toId, uint dungeonId)
         : base(partyId, partyType, partyName, maxParticipants, fromId, fromName, toId)
        {
            this.dungeonId = dungeonId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)dungeonId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            dungeonId = reader.ReadVarUShort();
        }
        
    }
    
}