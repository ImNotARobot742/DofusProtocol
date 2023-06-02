

// Generated on 06/02/2023 19:00:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildApplicationDeletedMessage : NetworkMessage
    {
        public const uint Id = 4455;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool deleted;
        
        public GuildApplicationDeletedMessage()
        {
        }
        
        public GuildApplicationDeletedMessage(bool deleted)
        {
            this.deleted = deleted;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(deleted);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            deleted = reader.ReadBoolean();
        }
        
    }
    
}