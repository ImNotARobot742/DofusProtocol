

// Generated on 06/13/2023 16:59:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendSetStatusShareMessage : NetworkMessage
    {
        public const uint Id = 5953;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool share;
        
        public FriendSetStatusShareMessage()
        {
        }
        
        public FriendSetStatusShareMessage(bool share)
        {
            this.share = share;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(share);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            share = reader.ReadBoolean();
        }
        
    }
    
}