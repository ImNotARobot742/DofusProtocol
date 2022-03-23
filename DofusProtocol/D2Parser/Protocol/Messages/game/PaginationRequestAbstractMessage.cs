

// Generated on 03/23/2022 09:50:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaginationRequestAbstractMessage : NetworkMessage
    {
        public const uint Id = 3535;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double offset;
        public uint count;
        
        public PaginationRequestAbstractMessage()
        {
        }
        
        public PaginationRequestAbstractMessage(double offset, uint count)
        {
            this.offset = offset;
            this.count = count;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(offset);
            writer.WriteUInt(count);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            offset = reader.ReadDouble();
            count = reader.ReadUInt();
        }
        
    }
    
}