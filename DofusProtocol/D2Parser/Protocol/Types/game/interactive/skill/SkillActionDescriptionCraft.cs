

// Generated on 01/01/2022 14:40:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SkillActionDescriptionCraft : SkillActionDescription
    {
        public const short Id = 6151;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte probability;
        
        public SkillActionDescriptionCraft()
        {
        }
        
        public SkillActionDescriptionCraft(uint skillId, sbyte probability)
         : base(skillId)
        {
            this.probability = probability;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(probability);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            probability = reader.ReadSbyte();
        }
        
    }
    
}