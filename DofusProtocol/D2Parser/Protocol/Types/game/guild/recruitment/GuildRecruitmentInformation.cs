

// Generated on 05/18/2023 16:29:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildRecruitmentInformation
    {
        public const short Id = 2397;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public bool minLevelFacultative;
        public bool minSuccessFacultative;
        public bool invalidatedByModeration;
        public bool recruitmentAutoLocked;
        public uint guildId;
        public sbyte recruitmentType;
        public string recruitmentTitle;
        public string recruitmentText;
        public uint[] selectedLanguages;
        public uint[] selectedCriterion;
        public short minLevel;
        public uint minSuccess;
        public string lastEditPlayerName;
        public double lastEditDate;
        
        public GuildRecruitmentInformation()
        {
        }
        
        public GuildRecruitmentInformation(bool minLevelFacultative, bool minSuccessFacultative, bool invalidatedByModeration, bool recruitmentAutoLocked, uint guildId, sbyte recruitmentType, string recruitmentTitle, string recruitmentText, uint[] selectedLanguages, uint[] selectedCriterion, short minLevel, uint minSuccess, string lastEditPlayerName, double lastEditDate)
        {
            this.minLevelFacultative = minLevelFacultative;
            this.minSuccessFacultative = minSuccessFacultative;
            this.invalidatedByModeration = invalidatedByModeration;
            this.recruitmentAutoLocked = recruitmentAutoLocked;
            this.guildId = guildId;
            this.recruitmentType = recruitmentType;
            this.recruitmentTitle = recruitmentTitle;
            this.recruitmentText = recruitmentText;
            this.selectedLanguages = selectedLanguages;
            this.selectedCriterion = selectedCriterion;
            this.minLevel = minLevel;
            this.minSuccess = minSuccess;
            this.lastEditPlayerName = lastEditPlayerName;
            this.lastEditDate = lastEditDate;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, minLevelFacultative);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, minSuccessFacultative);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, invalidatedByModeration);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 3, recruitmentAutoLocked);
            writer.WriteByte(flag1);
            writer.WriteVarInt((int)guildId);
            writer.WriteSbyte(recruitmentType);
            writer.WriteUTF(recruitmentTitle);
            writer.WriteUTF(recruitmentText);
            writer.WriteShort((short)selectedLanguages.Length);
            foreach (var entry in selectedLanguages)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)selectedCriterion.Length);
            foreach (var entry in selectedCriterion)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort(minLevel);
            writer.WriteVarInt((int)minSuccess);
            writer.WriteUTF(lastEditPlayerName);
            writer.WriteDouble(lastEditDate);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            byte flag1 = reader.ReadByte();
            minLevelFacultative = BooleanByteWrapper.GetFlag(flag1, 0);
            minSuccessFacultative = BooleanByteWrapper.GetFlag(flag1, 1);
            invalidatedByModeration = BooleanByteWrapper.GetFlag(flag1, 2);
            recruitmentAutoLocked = BooleanByteWrapper.GetFlag(flag1, 3);
            guildId = reader.ReadVarUInt();
            recruitmentType = reader.ReadSbyte();
            recruitmentTitle = reader.ReadUTF();
            recruitmentText = reader.ReadUTF();
            var limit = (ushort)reader.ReadUShort();
            selectedLanguages = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 selectedLanguages[i] = reader.ReadVarUInt();
            }
            limit = (ushort)reader.ReadUShort();
            selectedCriterion = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 selectedCriterion[i] = reader.ReadVarUInt();
            }
            minLevel = reader.ReadShort();
            minSuccess = reader.ReadVarUInt();
            lastEditPlayerName = reader.ReadUTF();
            lastEditDate = reader.ReadDouble();
        }
        
    }
    
}