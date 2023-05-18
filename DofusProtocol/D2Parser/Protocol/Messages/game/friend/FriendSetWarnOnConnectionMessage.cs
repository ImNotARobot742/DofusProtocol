

// Generated on 05/18/2023 16:28:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendSetWarnOnConnectionMessage : NetworkMessage
    {
        public const uint Id = 5804;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool enable;
        
        public FriendSetWarnOnConnectionMessage()
        {
        }
        
        public FriendSetWarnOnConnectionMessage(bool enable)
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