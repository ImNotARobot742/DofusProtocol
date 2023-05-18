

// Generated on 05/18/2023 16:29:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class UpdateMountIntegerCharacteristic : UpdateMountCharacteristic
    {
        public const short Id = 1105;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int value;
        
        public UpdateMountIntegerCharacteristic()
        {
        }
        
        public UpdateMountIntegerCharacteristic(sbyte type, int value)
         : base(type)
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