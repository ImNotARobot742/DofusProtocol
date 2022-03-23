

// Generated on 03/23/2022 09:50:32
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
        public const uint Id = 1646;
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