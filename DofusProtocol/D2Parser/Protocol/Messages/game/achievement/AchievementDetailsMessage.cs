

// Generated on 03/23/2022 09:50:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AchievementDetailsMessage : NetworkMessage
    {
        public const uint Id = 7443;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.Achievement achievement;
        
        public AchievementDetailsMessage()
        {
        }
        
        public AchievementDetailsMessage(Types.Achievement achievement)
        {
            this.achievement = achievement;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            achievement.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            achievement = new Types.Achievement();
            achievement.Deserialize(reader);
        }
        
    }
    
}