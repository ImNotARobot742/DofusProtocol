

// Generated on 03/23/2022 09:50:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChallengeTargetUpdateMessage : NetworkMessage
    {
        public const uint Id = 748;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint challengeId;
        public double targetId;
        
        public ChallengeTargetUpdateMessage()
        {
        }
        
        public ChallengeTargetUpdateMessage(uint challengeId, double targetId)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)challengeId);
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            challengeId = reader.ReadVarUShort();
            targetId = reader.ReadDouble();
        }
        
    }
    
}