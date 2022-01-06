

// Generated on 01/01/2022 14:40:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class HouseInformations
    {
        public const short Id = 3346;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint houseId;
        public uint modelId;
        
        public HouseInformations()
        {
        }
        
        public HouseInformations(uint houseId, uint modelId)
        {
            this.houseId = houseId;
            this.modelId = modelId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteVarShort((short)modelId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            houseId = reader.ReadVarUInt();
            modelId = reader.ReadVarUShort();
        }
        
    }
    
}