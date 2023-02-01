

// Generated on 02/01/2023 12:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaginationAnswerAbstractMessage : NetworkMessage
    {
        public const uint Id = 2497;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double offset;
        public uint count;
        public uint total;
        
        public PaginationAnswerAbstractMessage()
        {
        }
        
        public PaginationAnswerAbstractMessage(double offset, uint count, uint total)
        {
            this.offset = offset;
            this.count = count;
            this.total = total;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(offset);
            writer.WriteUInt(count);
            writer.WriteUInt(total);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            offset = reader.ReadDouble();
            count = reader.ReadUInt();
            total = reader.ReadUInt();
        }
        
    }
    
}