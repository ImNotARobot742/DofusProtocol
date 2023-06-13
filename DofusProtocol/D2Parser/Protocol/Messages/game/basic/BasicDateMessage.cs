

// Generated on 06/13/2023 16:59:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BasicDateMessage : NetworkMessage
    {
        public const uint Id = 9259;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte day;
        public sbyte month;
        public short year;
        
        public BasicDateMessage()
        {
        }
        
        public BasicDateMessage(sbyte day, sbyte month, short year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(day);
            writer.WriteSbyte(month);
            writer.WriteShort(year);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            day = reader.ReadSbyte();
            month = reader.ReadSbyte();
            year = reader.ReadShort();
        }
        
    }
    
}