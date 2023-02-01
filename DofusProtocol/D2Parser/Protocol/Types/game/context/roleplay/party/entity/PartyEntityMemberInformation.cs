

// Generated on 02/01/2023 12:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PartyEntityMemberInformation : PartyEntityBaseInformation
    {
        public const short Id = 8077;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint initiative;
        public uint lifePoints;
        public uint maxLifePoints;
        public uint prospecting;
        public byte regenRate;
        
        public PartyEntityMemberInformation()
        {
        }
        
        public PartyEntityMemberInformation(sbyte indexId, sbyte entityModelId, Types.EntityLook entityLook, uint initiative, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate)
         : base(indexId, entityModelId, entityLook)
        {
            this.initiative = initiative;
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.prospecting = prospecting;
            this.regenRate = regenRate;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)initiative);
            writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            writer.WriteVarShort((short)prospecting);
            writer.WriteByte(regenRate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            initiative = reader.ReadVarUShort();
            lifePoints = reader.ReadVarUInt();
            maxLifePoints = reader.ReadVarUInt();
            prospecting = reader.ReadVarUShort();
            regenRate = reader.ReadByte();
        }
        
    }
    
}