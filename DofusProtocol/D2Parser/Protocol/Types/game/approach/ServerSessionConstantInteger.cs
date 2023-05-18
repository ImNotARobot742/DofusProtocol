

// Generated on 05/18/2023 15:10:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ServerSessionConstantInteger : ServerSessionConstant
    {
        public const short Id = 6624;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int value;
        
        public ServerSessionConstantInteger()
        {
        }
        
        public ServerSessionConstantInteger(uint id, int value)
         : base(id)
        {
            this.value = value;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadInt();
        }
        
    }
    
}