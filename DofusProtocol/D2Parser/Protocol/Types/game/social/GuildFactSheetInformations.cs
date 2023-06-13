

// Generated on 06/13/2023 17:00:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildFactSheetInformations : GuildInformations
    {
        public const short Id = 3899;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double leaderId;
        public uint nbMembers;
        public short lastActivityDay;
        public Types.GuildRecruitmentInformation recruitment;
        public int nbPendingApply;
        
        public GuildFactSheetInformations()
        {
        }
        
        public GuildFactSheetInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, double leaderId, uint nbMembers, short lastActivityDay, Types.GuildRecruitmentInformation recruitment, int nbPendingApply)
         : base(guildId, guildName, guildLevel, guildEmblem)
        {
            this.leaderId = leaderId;
            this.nbMembers = nbMembers;
            this.lastActivityDay = lastActivityDay;
            this.recruitment = recruitment;
            this.nbPendingApply = nbPendingApply;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(leaderId);
            writer.WriteVarShort((short)nbMembers);
            writer.WriteShort(lastActivityDay);
            recruitment.Serialize(writer);
            writer.WriteInt(nbPendingApply);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            leaderId = reader.ReadVarULong();
            nbMembers = reader.ReadVarUShort();
            lastActivityDay = reader.ReadShort();
            recruitment = new Types.GuildRecruitmentInformation();
            recruitment.Deserialize(reader);
            nbPendingApply = reader.ReadInt();
        }
        
    }
    
}