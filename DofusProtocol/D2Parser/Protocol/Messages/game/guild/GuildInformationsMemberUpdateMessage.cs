

// Generated on 03/23/2022 09:50:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildInformationsMemberUpdateMessage : NetworkMessage
    {
        public const uint Id = 2768;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GuildMember member;
        
        public GuildInformationsMemberUpdateMessage()
        {
        }
        
        public GuildInformationsMemberUpdateMessage(Types.GuildMember member)
        {
            this.member = member;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            member.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            member = new Types.GuildMember();
            member.Deserialize(reader);
        }
        
    }
    
}