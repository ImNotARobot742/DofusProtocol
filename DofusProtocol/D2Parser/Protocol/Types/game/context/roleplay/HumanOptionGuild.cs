

// Generated on 05/18/2023 15:10:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class HumanOptionGuild : HumanOption
    {
        public const short Id = 6904;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.GuildInformations guildInformations;
        
        public HumanOptionGuild()
        {
        }
        
        public HumanOptionGuild(Types.GuildInformations guildInformations)
        {
            this.guildInformations = guildInformations;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            guildInformations.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            guildInformations = new Types.GuildInformations();
            guildInformations.Deserialize(reader);
        }
        
    }
    
}