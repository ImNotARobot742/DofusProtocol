

// Generated on 06/13/2023 17:00:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildInformations : BasicGuildInformations
    {
        public const short Id = 1378;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.GuildEmblem guildEmblem;
        
        public GuildInformations()
        {
        }
        
        public GuildInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem)
         : base(guildId, guildName, guildLevel)
        {
            this.guildEmblem = guildEmblem;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            guildEmblem.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
        }
        
    }
    
}