

// Generated on 03/23/2022 09:50:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildApplicationIsAnsweredMessage : NetworkMessage
    {
        public const uint Id = 3119;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool accepted;
        public Types.GuildInformations guildInformation;
        
        public GuildApplicationIsAnsweredMessage()
        {
        }
        
        public GuildApplicationIsAnsweredMessage(bool accepted, Types.GuildInformations guildInformation)
        {
            this.accepted = accepted;
            this.guildInformation = guildInformation;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(accepted);
            guildInformation.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            accepted = reader.ReadBoolean();
            guildInformation = new Types.GuildInformations();
            guildInformation.Deserialize(reader);
        }
        
    }
    
}