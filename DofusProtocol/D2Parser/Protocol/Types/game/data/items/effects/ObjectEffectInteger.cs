

// Generated on 06/13/2023 17:00:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ObjectEffectInteger : ObjectEffect
    {
        public const short Id = 2318;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint value;
        
        public ObjectEffectInteger()
        {
        }
        
        public ObjectEffectInteger(uint actionId, uint value)
         : base(actionId)
        {
            this.value = value;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadVarUInt();
        }
        
    }
    
}