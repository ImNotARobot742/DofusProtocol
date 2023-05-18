

// Generated on 05/18/2023 15:10:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AbstractPartyMemberInFightMessage : AbstractPartyMessage
    {
        public const uint Id = 3039;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        public double memberId;
        public int memberAccountId;
        public string memberName;
        public uint fightId;
        public int timeBeforeFightStart;
        
        public AbstractPartyMemberInFightMessage()
        {
        }
        
        public AbstractPartyMemberInFightMessage(uint partyId, sbyte reason, double memberId, int memberAccountId, string memberName, uint fightId, int timeBeforeFightStart)
         : base(partyId)
        {
            this.reason = reason;
            this.memberId = memberId;
            this.memberAccountId = memberAccountId;
            this.memberName = memberName;
            this.fightId = fightId;
            this.timeBeforeFightStart = timeBeforeFightStart;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(reason);
            writer.WriteVarLong(memberId);
            writer.WriteInt(memberAccountId);
            writer.WriteUTF(memberName);
            writer.WriteVarShort((short)fightId);
            writer.WriteVarShort((short)timeBeforeFightStart);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            reason = reader.ReadSbyte();
            memberId = reader.ReadVarULong();
            memberAccountId = reader.ReadInt();
            memberName = reader.ReadUTF();
            fightId = reader.ReadVarUShort();
            timeBeforeFightStart = reader.ReadVarShort();
        }
        
    }
    
}