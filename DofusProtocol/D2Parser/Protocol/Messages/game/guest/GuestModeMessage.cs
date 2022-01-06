

// Generated on 01/01/2022 14:39:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuestModeMessage : NetworkMessage
    {
        public const uint Id = 9430;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool active;
        
        public GuestModeMessage()
        {
        }
        
        public GuestModeMessage(bool active)
        {
            this.active = active;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(active);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            active = reader.ReadBoolean();
        }
        
    }
    
}