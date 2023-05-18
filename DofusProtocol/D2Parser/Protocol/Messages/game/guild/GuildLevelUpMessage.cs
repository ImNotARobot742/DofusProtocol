

// Generated on 05/18/2023 16:28:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildLevelUpMessage : NetworkMessage
    {
        public const uint Id = 1293;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public byte newLevel;
        
        public GuildLevelUpMessage()
        {
        }
        
        public GuildLevelUpMessage(byte newLevel)
        {
            this.newLevel = newLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(newLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            newLevel = reader.ReadByte();
        }
        
    }
    
}