

// Generated on 06/13/2023 16:59:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlmanachCalendarDateMessage : NetworkMessage
    {
        public const uint Id = 1972;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int date;
        
        public AlmanachCalendarDateMessage()
        {
        }
        
        public AlmanachCalendarDateMessage(int date)
        {
            this.date = date;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(date);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            date = reader.ReadInt();
        }
        
    }
    
}