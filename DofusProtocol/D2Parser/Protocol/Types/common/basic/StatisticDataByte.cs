

// Generated on 03/23/2022 09:51:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class StatisticDataByte : StatisticData
    {
        public const short Id = 7113;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte value;
        
        public StatisticDataByte()
        {
        }
        
        public StatisticDataByte(sbyte value)
        {
            this.value = value;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadSbyte();
        }
        
    }
    
}