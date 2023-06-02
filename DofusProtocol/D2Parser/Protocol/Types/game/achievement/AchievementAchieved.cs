

// Generated on 06/02/2023 19:01:12
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AchievementAchieved
    {
        public const short Id = 2177;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        public double achievedBy;
        
        public AchievementAchieved()
        {
        }
        
        public AchievementAchieved(uint id, double achievedBy)
        {
            this.id = id;
            this.achievedBy = achievedBy;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)id);
            writer.WriteVarLong(achievedBy);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUShort();
            achievedBy = reader.ReadVarULong();
        }
        
    }
    
}