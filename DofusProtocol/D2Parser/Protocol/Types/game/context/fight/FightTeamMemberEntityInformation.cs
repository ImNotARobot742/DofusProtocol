

// Generated on 05/18/2023 15:10:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightTeamMemberEntityInformation : FightTeamMemberInformations
    {
        public const short Id = 9982;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte entityModelId;
        public uint level;
        public double masterId;
        
        public FightTeamMemberEntityInformation()
        {
        }
        
        public FightTeamMemberEntityInformation(double id, sbyte entityModelId, uint level, double masterId)
         : base(id)
        {
            this.entityModelId = entityModelId;
            this.level = level;
            this.masterId = masterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(entityModelId);
            writer.WriteVarShort((short)level);
            writer.WriteDouble(masterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            entityModelId = reader.ReadSbyte();
            level = reader.ReadVarUShort();
            masterId = reader.ReadDouble();
        }
        
    }
    
}