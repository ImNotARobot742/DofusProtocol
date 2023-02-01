

// Generated on 02/01/2023 12:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SpawnCompanionInformation : SpawnInformation
    {
        public const short Id = 8648;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte modelId;
        public uint level;
        public double summonerId;
        public double ownerId;
        
        public SpawnCompanionInformation()
        {
        }
        
        public SpawnCompanionInformation(sbyte modelId, uint level, double summonerId, double ownerId)
        {
            this.modelId = modelId;
            this.level = level;
            this.summonerId = summonerId;
            this.ownerId = ownerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(modelId);
            writer.WriteVarShort((short)level);
            writer.WriteDouble(summonerId);
            writer.WriteDouble(ownerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            modelId = reader.ReadSbyte();
            level = reader.ReadVarUShort();
            summonerId = reader.ReadDouble();
            ownerId = reader.ReadDouble();
        }
        
    }
    
}