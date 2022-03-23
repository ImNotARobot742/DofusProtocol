

// Generated on 03/23/2022 09:51:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AchievementAchievedRewardable : AchievementAchieved
    {
        public const short Id = 7808;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint finishedlevel;
        
        public AchievementAchievedRewardable()
        {
        }
        
        public AchievementAchievedRewardable(uint id, double achievedBy, uint finishedlevel)
         : base(id, achievedBy)
        {
            this.finishedlevel = finishedlevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)finishedlevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            finishedlevel = reader.ReadVarUShort();
        }
        
    }
    
}