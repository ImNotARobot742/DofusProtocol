

// Generated on 03/23/2022 09:50:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AchievementDetailsRequestMessage : NetworkMessage
    {
        public const uint Id = 4293;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint achievementId;
        
        public AchievementDetailsRequestMessage()
        {
        }
        
        public AchievementDetailsRequestMessage(uint achievementId)
        {
            this.achievementId = achievementId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)achievementId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            achievementId = reader.ReadVarUShort();
        }
        
    }
    
}