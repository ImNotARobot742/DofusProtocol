

// Generated on 05/18/2023 15:10:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildInAllianceInformations : GuildInformations
    {
        public const short Id = 1460;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public byte nbMembers;
        public int joinDate;
        
        public GuildInAllianceInformations()
        {
        }
        
        public GuildInAllianceInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, byte nbMembers, int joinDate)
         : base(guildId, guildName, guildLevel, guildEmblem)
        {
            this.nbMembers = nbMembers;
            this.joinDate = joinDate;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(nbMembers);
            writer.WriteInt(joinDate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            nbMembers = reader.ReadByte();
            joinDate = reader.ReadInt();
        }
        
    }
    
}