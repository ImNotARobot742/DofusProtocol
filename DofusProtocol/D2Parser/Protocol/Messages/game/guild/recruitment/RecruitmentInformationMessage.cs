

// Generated on 05/18/2023 15:10:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class RecruitmentInformationMessage : NetworkMessage
    {
        public const uint Id = 1633;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GuildRecruitmentInformation recruitmentData;
        
        public RecruitmentInformationMessage()
        {
        }
        
        public RecruitmentInformationMessage(Types.GuildRecruitmentInformation recruitmentData)
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