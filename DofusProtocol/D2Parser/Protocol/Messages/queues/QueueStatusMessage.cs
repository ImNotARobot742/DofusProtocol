

// Generated on 06/02/2023 19:00:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QueueStatusMessage : NetworkMessage
    {
        public const uint Id = 9417;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public ushort position;
        public ushort total;
        
        public QueueStatusMessage()
        {
        }
        
        public QueueStatusMessage(ushort position, ushort total)
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