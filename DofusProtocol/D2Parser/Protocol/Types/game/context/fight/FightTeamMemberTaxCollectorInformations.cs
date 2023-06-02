

// Generated on 06/02/2023 19:01:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightTeamMemberTaxCollectorInformations : FightTeamMemberInformations
    {
        public const short Id = 30;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint firstNameId;
        public uint lastNameId;
        public byte level;
        public uint guildId;
        public double uid;
        
        public FightTeamMemberTaxCollectorInformations()
        {
        }
        
        public FightTeamMemberTaxCollectorInformations(double id, uint firstNameId, uint lastNameId, byte level, uint guildId, double uid)
         : base(id)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.level = level;
            this.guildId = guildId;
            this.uid = uid;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)firstNameId);
            writer.WriteVarShort((short)lastNameId);
            writer.WriteByte(level);
            writer.WriteVarInt((int)guildId);
            writer.WriteDouble(uid);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            firstNameId = reader.ReadVarUShort();
            lastNameId = reader.ReadVarUShort();
            level = reader.ReadByte();
            guildId = reader.ReadVarUInt();
            uid = reader.ReadDouble();
        }
        
    }
    
}