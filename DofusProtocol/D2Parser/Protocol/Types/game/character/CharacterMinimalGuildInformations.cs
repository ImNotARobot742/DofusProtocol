

// Generated on 05/18/2023 15:10:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
    {
        public const short Id = 2061;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.BasicGuildInformations guild;
        
        public CharacterMinimalGuildInformations()
        {
        }
        
        public CharacterMinimalGuildInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, Types.BasicGuildInformations guild)
         : base(id, name, level, entityLook, breed)
        {
            this.guild = guild;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            guild.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
        }
        
    }
    
}