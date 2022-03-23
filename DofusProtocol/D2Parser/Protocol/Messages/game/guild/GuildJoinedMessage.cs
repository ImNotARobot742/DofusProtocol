

// Generated on 03/23/2022 09:50:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildJoinedMessage : NetworkMessage
    {
        public const uint Id = 2641;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GuildInformations guildInfo;
        public uint rankId;
        
        public GuildJoinedMessage()
        {
        }
        
        public GuildJoinedMessage(Types.GuildInformations guildInfo, uint rankId)
        {
            this.guildInfo = guildInfo;
            this.rankId = rankId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            guildInfo.Serialize(writer);
            writer.WriteVarInt((int)rankId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            rankId = reader.ReadVarUInt();
        }
        
    }
    
}