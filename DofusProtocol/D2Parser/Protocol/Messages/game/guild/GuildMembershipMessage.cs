

// Generated on 03/23/2022 09:50:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildMembershipMessage : GuildJoinedMessage
    {
        public const uint Id = 2565;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GuildMembershipMessage()
        {
        }
        
        public GuildMembershipMessage(Types.GuildInformations guildInfo, uint rankId)
         : base(guildInfo, rankId)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}