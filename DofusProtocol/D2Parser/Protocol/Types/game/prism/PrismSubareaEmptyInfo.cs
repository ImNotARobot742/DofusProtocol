

// Generated on 05/18/2023 16:29:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PrismSubareaEmptyInfo
    {
        public const short Id = 6181;
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