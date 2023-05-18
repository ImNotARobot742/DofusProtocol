

// Generated on 05/18/2023 15:10:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AlterationInfo
    {
        public const short Id = 5142;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint alterationId;
        public double creationTime;
        public sbyte expirationType;
        public double expirationValue;
        public Types.ObjectEffect[] effects;
        
        public AlterationInfo()
        {
        }
        
        public AlterationInfo(uint alterationId, double creationTime, sbyte expirationType, double expirationValue, Types.ObjectEffect[] effects)
        {
            this.alterationId = alterationId;
            this.creationTime = creationTime;
            this.expirationType = expirationType;
            this.expirationValue = expirationValue;
            this.effects = effects;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteUInt(alterationId);
            writer.WriteDouble(creationTime);
            writer.WriteSbyte(expirationType);
            writer.WriteDouble(expirationValue);
            writer.WriteShort((short)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            alterationId = reader.ReadUInt();
            creationTime = reader.ReadDouble();
            expirationType = reader.ReadSbyte();
            expirationValue = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 effects[i].Deserialize(reader);
            }
        }
        
    }
    
}