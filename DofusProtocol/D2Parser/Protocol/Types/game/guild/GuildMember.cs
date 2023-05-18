

// Generated on 05/18/2023 16:29:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildMember : CharacterMinimalInformations
    {
        public const short Id = 6328;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public bool sex;
        public bool havenBagShared;
        public sbyte breed;
        public uint rankId;
        public double enrollmentDate;
        public double givenExperience;
        public sbyte experienceGivenPercent;
        public sbyte connected;
        public sbyte alignmentSide;
        public ushort hoursSinceLastConnection;
        public uint moodSmileyId;
        public int accountId;
        public int achievementPoints;
        public Types.PlayerStatus status;
        public Types.PlayerNote note;
        
        public GuildMember()
        {
        }
        
        public GuildMember(double id, string name, uint level, bool sex, bool havenBagShared, sbyte breed, uint rankId, double enrollmentDate, double givenExperience, sbyte experienceGivenPercent, sbyte connected, sbyte alignmentSide, ushort hoursSinceLastConnection, uint moodSmileyId, int accountId, int achievementPoints, Types.PlayerStatus status, Types.PlayerNote note)
         : base(id, name, level)
        {
            this.sex = sex;
            this.havenBagShared = havenBagShared;
            this.breed = breed;
            this.rankId = rankId;
            this.enrollmentDate = enrollmentDate;
            this.givenExperience = givenExperience;
            this.experienceGivenPercent = experienceGivenPercent;
            this.connected = connected;
            this.alignmentSide = alignmentSide;
            this.hoursSinceLastConnection = hoursSinceLastConnection;
            this.moodSmileyId = moodSmileyId;
            this.accountId = accountId;
            this.achievementPoints = achievementPoints;
            this.status = status;
            this.note = note;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, sex);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, havenBagShared);
            writer.WriteByte(flag1);
            writer.WriteSbyte(breed);
            writer.WriteVarInt((int)rankId);
            writer.WriteDouble(enrollmentDate);
            writer.WriteVarLong(givenExperience);
            writer.WriteSbyte(experienceGivenPercent);
            writer.WriteSbyte(connected);
            writer.WriteSbyte(alignmentSide);
            writer.WriteUShort(hoursSinceLastConnection);
            writer.WriteVarShort((short)moodSmileyId);
            writer.WriteInt(accountId);
            writer.WriteInt(achievementPoints);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            note.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            sex = BooleanByteWrapper.GetFlag(flag1, 0);
            havenBagShared = BooleanByteWrapper.GetFlag(flag1, 1);
            breed = reader.ReadSbyte();
            rankId = reader.ReadVarUInt();
            enrollmentDate = reader.ReadDouble();
            givenExperience = reader.ReadVarULong();
            experienceGivenPercent = reader.ReadSbyte();
            connected = reader.ReadSbyte();
            alignmentSide = reader.ReadSbyte();
            hoursSinceLastConnection = reader.ReadUShort();
            moodSmileyId = reader.ReadVarUShort();
            accountId = reader.ReadInt();
            achievementPoints = reader.ReadInt();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
            note = new Types.PlayerNote();
            note.Deserialize(reader);
        }
        
    }
    
}