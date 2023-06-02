

// Generated on 06/02/2023 19:01:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SkillActionDescriptionCollect : SkillActionDescriptionTimed
    {
        public const short Id = 2829;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint min;
        public uint max;
        
        public SkillActionDescriptionCollect()
        {
        }
        
        public SkillActionDescriptionCollect(uint skillId, byte time, uint min, uint max)
         : base(skillId, time)
        {
            this.min = min;
            this.max = max;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)min);
            writer.WriteVarShort((short)max);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            min = reader.ReadVarUShort();
            max = reader.ReadVarUShort();
        }
        
    }
    
}