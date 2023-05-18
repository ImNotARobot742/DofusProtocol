

// Generated on 05/18/2023 15:10:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ServerSessionConstantLong : ServerSessionConstant
    {
        public const short Id = 5548;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double value;
        
        public ServerSessionConstantLong()
        {
        }
        
        public ServerSessionConstantLong(uint id, double value)
         : base(id)
        {
            this.value = value;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadDouble();
        }
        
    }
    
}