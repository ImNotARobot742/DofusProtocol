

// Generated on 05/18/2023 15:10:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChallengeInfoMessage : NetworkMessage
    {
        public const uint Id = 4866;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint challengeId;
        public double targetId;
        public uint xpBonus;
        public uint dropBonus;
        
        public ChallengeInfoMessage()
        {
        }
        
        public ChallengeInfoMessage(uint challengeId, double targetId, uint xpBonus, uint dropBonus)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
            this.xpBonus = xpBonus;
            this.dropBonus = dropBonus;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)challengeId);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)xpBonus);
            writer.WriteVarInt((int)dropBonus);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            challengeId = reader.ReadVarUShort();
            targetId = reader.ReadDouble();
            xpBonus = reader.ReadVarUInt();
            dropBonus = reader.ReadVarUInt();
        }
        
    }
    
}