

// Generated on 06/02/2023 19:00:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class UpdateRecruitmentInformationMessage : NetworkMessage
    {
        public const uint Id = 6413;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GuildRecruitmentInformation recruitmentData;
        
        public UpdateRecruitmentInformationMessage()
        {
        }
        
        public UpdateRecruitmentInformationMessage(Types.GuildRecruitmentInformation recruitmentData)
        {
            this.recruitmentData = recruitmentData;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            recruitmentData.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            recruitmentData = new Types.GuildRecruitmentInformation();
            recruitmentData.Deserialize(reader);
        }
        
    }
    
}