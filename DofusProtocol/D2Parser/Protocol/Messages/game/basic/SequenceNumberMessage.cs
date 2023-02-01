

// Generated on 02/01/2023 12:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SequenceNumberMessage : NetworkMessage
    {
        public const uint Id = 116;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public ushort number;
        
        public SequenceNumberMessage()
        {
        }
        
        public SequenceNumberMessage(ushort number)
        {
            this.number = number;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(number);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            number = reader.ReadUShort();
        }
        
    }
    
}