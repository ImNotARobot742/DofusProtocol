

// Generated on 03/23/2022 09:50:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendAddFailureMessage : NetworkMessage
    {
        public const uint Id = 9647;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public FriendAddFailureMessage()
        {
        }
        
        public FriendAddFailureMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            reason = reader.ReadSbyte();
        }
        
    }
    
}