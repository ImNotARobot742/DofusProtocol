

// Generated on 03/23/2022 09:51:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class InteractiveElementNamedSkill : InteractiveElementSkill
    {
        public const short Id = 8189;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint nameId;
        
        public InteractiveElementNamedSkill()
        {
        }
        
        public InteractiveElementNamedSkill(uint skillId, int skillInstanceUid, uint nameId)
         : base(skillId, skillInstanceUid)
        {
            this.nameId = nameId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)nameId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            nameId = reader.ReadVarUInt();
        }
        
    }
    
}