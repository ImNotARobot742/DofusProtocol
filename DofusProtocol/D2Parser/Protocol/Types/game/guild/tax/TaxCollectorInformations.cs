

// Generated on 06/02/2023 19:01:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TaxCollectorInformations
    {
        public const short Id = 1044;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double uniqueId;
        public uint firtNameId;
        public uint lastNameId;
        public Types.AdditionalTaxCollectorInformations additionalInfos;
        public short worldX;
        public short worldY;
        public uint subAreaId;
        public sbyte state;
        public Types.EntityLook look;
        public Types.TaxCollectorComplementaryInformations[] complements;
        
        public TaxCollectorInformations()
        {
        }
        
        public TaxCollectorInformations(double uniqueId, uint firtNameId, uint lastNameId, Types.AdditionalTaxCollectorInformations additionalInfos, short worldX, short worldY, uint subAreaId, sbyte state, Types.EntityLook look, Types.TaxCollectorComplementaryInformations[] complements)
        {
            this.uniqueId = uniqueId;
            this.firtNameId = firtNameId;
            this.lastNameId = lastNameId;
            this.additionalInfos = additionalInfos;
            this.worldX = worldX;
            this.worldY = worldY;
            this.subAreaId = subAreaId;
            this.state = state;
            this.look = look;
            this.complements = complements;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(uniqueId);
            writer.WriteVarShort((short)firtNameId);
            writer.WriteVarShort((short)lastNameId);
            additionalInfos.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteVarShort((short)subAreaId);
            writer.WriteSbyte(state);
            look.Serialize(writer);
            writer.WriteShort((short)complements.Length);
            foreach (var entry in complements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            uniqueId = reader.ReadDouble();
            firtNameId = reader.ReadVarUShort();
            lastNameId = reader.ReadVarUShort();
            additionalInfos = new Types.AdditionalTaxCollectorInformations();
            additionalInfos.Deserialize(reader);
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            subAreaId = reader.ReadVarUShort();
            state = reader.ReadSbyte();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            complements = new Types.TaxCollectorComplementaryInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 complements[i] = ProtocolTypeManager.GetInstance<Types.TaxCollectorComplementaryInformations>(reader.ReadUShort());
                 complements[i].Deserialize(reader);
            }
        }
        
    }
    
}