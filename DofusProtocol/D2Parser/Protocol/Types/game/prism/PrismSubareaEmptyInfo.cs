

// Generated on 02/01/2023 12:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PrismSubareaEmptyInfo
    {
        public const short Id = 3717;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        public uint allianceId;
        
        public PrismSubareaEmptyInfo()
        {
        }
        
        public PrismSubareaEmptyInfo(uint subAreaId, uint allianceId)
        {
            this.subAreaId = subAreaId;
            this.allianceId = allianceId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)subAreaId);
            writer.WriteVarInt((int)allianceId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUShort();
            allianceId = reader.ReadVarUInt();
        }
        
    }
    
}