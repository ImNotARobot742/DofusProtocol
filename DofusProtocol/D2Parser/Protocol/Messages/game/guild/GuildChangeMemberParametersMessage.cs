

// Generated on 01/01/2022 14:39:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildChangeMemberParametersMessage : NetworkMessage
    {
        public const uint Id = 3633;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double memberId;
        public uint rank;
        public sbyte experienceGivenPercent;
        public uint rights;
        
        public GuildChangeMemberParametersMessage()
        {
        }
        
        public GuildChangeMemberParametersMessage(double memberId, uint rank, sbyte experienceGivenPercent, uint rights)
        {
            this.memberId = memberId;
            this.rank = rank;
            this.experienceGivenPercent = experienceGivenPercent;
            this.rights = rights;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(memberId);
            writer.WriteVarShort((short)rank);
            writer.WriteSbyte(experienceGivenPercent);
            writer.WriteVarInt((int)rights);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            memberId = reader.ReadVarULong();
            rank = reader.ReadVarUShort();
            experienceGivenPercent = reader.ReadSbyte();
            rights = reader.ReadVarUInt();
        }
        
    }
    
}