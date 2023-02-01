

// Generated on 02/01/2023 12:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AchievementAchieved
    {
        public const short Id = 7505;
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