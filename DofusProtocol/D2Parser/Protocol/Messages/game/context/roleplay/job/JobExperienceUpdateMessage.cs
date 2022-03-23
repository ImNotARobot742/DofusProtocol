

// Generated on 03/23/2022 09:50:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class JobExperienceUpdateMessage : NetworkMessage
    {
        public const uint Id = 9901;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.JobExperience experiencesUpdate;
        
        public JobExperienceUpdateMessage()
        {
        }
        
        public JobExperienceUpdateMessage(Types.JobExperience experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            experiencesUpdate.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            experiencesUpdate = new Types.JobExperience();
            experiencesUpdate.Deserialize(reader);
        }
        
    }
    
}