

// Generated on 03/23/2022 09:50:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendWarnOnConnectionStateMessage : NetworkMessage
    {
        public const uint Id = 2872;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool enable;
        
        public FriendWarnOnConnectionStateMessage()
        {
        }
        
        public FriendWarnOnConnectionStateMessage(bool enable)
        {
            this.enable = enable;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(enable);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            enable = reader.ReadBoolean();
        }
        
    }
    
}