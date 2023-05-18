

// Generated on 05/18/2023 15:11:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TaxCollectorBasicInformations
    {
        public const short Id = 7639;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint firstNameId;
        public uint lastNameId;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        
        public TaxCollectorBasicInformations()
        {
        }
        
        public TaxCollectorBasicInformations(uint firstNameId, uint lastNameId, short worldX, short worldY, double mapId, uint subAreaId)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)firstNameId);
            writer.WriteVarShort((short)lastNameId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((short)subAreaId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            firstNameId = reader.ReadVarUShort();
            lastNameId = reader.ReadVarUShort();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUShort();
        }
        
    }
    
}