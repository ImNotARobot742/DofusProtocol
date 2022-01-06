

// Generated on 01/01/2022 14:39:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ServerExperienceModificatorMessage : NetworkMessage
    {
        public const uint Id = 7180;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint experiencePercent;
        
        public ServerExperienceModificatorMessage()
        {
        }
        
        public ServerExperienceModificatorMessage(uint experiencePercent)
        {
            this.experiencePercent = experiencePercent;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)experiencePercent);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            experiencePercent = reader.ReadVarUShort();
        }
        
    }
    
}