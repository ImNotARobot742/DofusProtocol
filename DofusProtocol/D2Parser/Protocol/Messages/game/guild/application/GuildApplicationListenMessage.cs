

// Generated on 01/01/2022 14:39:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildApplicationListenMessage : NetworkMessage
    {
        public const uint Id = 9375;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool listen;
        
        public GuildApplicationListenMessage()
        {
        }
        
        public GuildApplicationListenMessage(bool listen)
        {
            this.listen = listen;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(listen);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            listen = reader.ReadBoolean();
        }
        
    }
    
}