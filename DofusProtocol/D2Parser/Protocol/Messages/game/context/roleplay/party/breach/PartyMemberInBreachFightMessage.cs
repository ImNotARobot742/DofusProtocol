

// Generated on 02/01/2023 12:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyMemberInBreachFightMessage : AbstractPartyMemberInFightMessage
    {
        public const uint Id = 1630;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint floor;
        public sbyte room;
        
        public PartyMemberInBreachFightMessage()
        {
        }
        
        public PartyMemberInBreachFightMessage(uint partyId, sbyte reason, double memberId, int memberAccountId, string memberName, uint fightId, int timeBeforeFightStart, uint floor, sbyte room)
         : base(partyId, reason, memberId, memberAccountId, memberName, fightId, timeBeforeFightStart)
        {
            this.floor = floor;
            this.room = room;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)floor);
            writer.WriteSbyte(room);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            floor = reader.ReadVarUInt();
            room = reader.ReadSbyte();
        }
        
    }
    
}