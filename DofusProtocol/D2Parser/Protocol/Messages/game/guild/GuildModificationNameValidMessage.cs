

// Generated on 05/18/2023 15:10:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildModificationNameValidMessage : NetworkMessage
    {
        public const uint Id = 7255;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string guildName;
        
        public GuildModificationNameValidMessage()
        {
        }
        
        public GuildModificationNameValidMessage(string guildName)
        {
            this.guildName = guildName;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(guildName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            guildName = reader.ReadUTF();
        }
        
    }
    
}