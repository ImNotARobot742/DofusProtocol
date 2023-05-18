

// Generated on 05/18/2023 16:29:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildUpdateApplicationMessage : NetworkMessage
    {
        public const uint Id = 9643;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string applyText;
        public uint guildId;
        
        public GuildUpdateApplicationMessage()
        {
        }
        
        public GuildUpdateApplicationMessage(string applyText, uint guildId)
        {
            this.applyText = applyText;
            this.guildId = guildId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(applyText);
            writer.WriteVarInt((int)guildId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            applyText = reader.ReadUTF();
            guildId = reader.ReadVarUInt();
        }
        
    }
    
}