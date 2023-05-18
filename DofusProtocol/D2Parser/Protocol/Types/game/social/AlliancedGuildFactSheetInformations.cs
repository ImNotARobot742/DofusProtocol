

// Generated on 05/18/2023 15:11:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AlliancedGuildFactSheetInformations : GuildInformations
    {
        public const short Id = 1200;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.BasicNamedAllianceInformations allianceInfos;
        
        public AlliancedGuildFactSheetInformations()
        {
        }
        
        public AlliancedGuildFactSheetInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, Types.BasicNamedAllianceInformations allianceInfos)
         : base(guildId, guildName, guildLevel, guildEmblem)
        {
            this.allianceInfos = allianceInfos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            allianceInfos.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            allianceInfos = new Types.BasicNamedAllianceInformations();
            allianceInfos.Deserialize(reader);
        }
        
    }
    
}