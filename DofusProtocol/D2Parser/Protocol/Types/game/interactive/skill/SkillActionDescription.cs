

// Generated on 02/01/2023 12:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SkillActionDescription
    {
        public const short Id = 8190;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint skillId;
        
        public SkillActionDescription()
        {
        }
        
        public SkillActionDescription(uint skillId)
        {
            this.skillId = skillId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)skillId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            skillId = reader.ReadVarUShort();
        }
        
    }
    
}