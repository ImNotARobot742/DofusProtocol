

// Generated on 05/18/2023 15:10:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class StatisticDataShort : StatisticData
    {
        public const short Id = 9582;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public short value;
        
        public StatisticDataShort()
        {
        }
        
        public StatisticDataShort(short value)
        {
            this.value = value;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadShort();
        }
        
    }
    
}