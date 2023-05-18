

// Generated on 05/18/2023 16:28:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuestLimitationMessage : NetworkMessage
    {
        public const uint Id = 6899;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public GuestLimitationMessage()
        {
        }
        
        public GuestLimitationMessage(sbyte reason)
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