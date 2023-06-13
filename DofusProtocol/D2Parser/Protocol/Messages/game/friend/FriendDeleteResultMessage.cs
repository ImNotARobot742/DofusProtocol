

// Generated on 06/13/2023 16:59:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendDeleteResultMessage : NetworkMessage
    {
        public const uint Id = 9837;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool success;
        public Types.AccountTagInformation tag;
        
        public FriendDeleteResultMessage()
        {
        }
        
        public FriendDeleteResultMessage(bool success, Types.AccountTagInformation tag)
        {
            this.success = success;
            this.tag = tag;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(success);
            tag.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            success = reader.ReadBoolean();
            tag = new Types.AccountTagInformation();
            tag.Deserialize(reader);
        }
        
    }
    
}