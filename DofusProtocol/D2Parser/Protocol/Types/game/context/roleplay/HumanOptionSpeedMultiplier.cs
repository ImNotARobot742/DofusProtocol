

// Generated on 05/18/2023 15:10:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class HumanOptionSpeedMultiplier : HumanOption
    {
        public const short Id = 1571;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint speedMultiplier;
        
        public HumanOptionSpeedMultiplier()
        {
        }
        
        public HumanOptionSpeedMultiplier(uint speedMultiplier)
        {
            this.speedMultiplier = speedMultiplier;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)speedMultiplier);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            speedMultiplier = reader.ReadVarUInt();
        }
        
    }
    
}