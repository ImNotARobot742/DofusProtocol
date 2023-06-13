

// Generated on 06/13/2023 16:59:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LoginQueueStatusMessage : NetworkMessage
    {
        public const uint Id = 9732;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public ushort position;
        public ushort total;
        
        public LoginQueueStatusMessage()
        {
        }
        
        public LoginQueueStatusMessage(ushort position, ushort total)
        {
            this.position = position;
            this.total = total;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(position);
            writer.WriteUShort(total);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            position = reader.ReadUShort();
            total = reader.ReadUShort();
        }
        
    }
    
}