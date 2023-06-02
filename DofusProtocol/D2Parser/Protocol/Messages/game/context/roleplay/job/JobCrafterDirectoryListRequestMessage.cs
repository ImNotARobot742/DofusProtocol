

// Generated on 06/02/2023 19:00:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class JobCrafterDirectoryListRequestMessage : NetworkMessage
    {
        public const uint Id = 9236;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte jobId;
        
        public JobCrafterDirectoryListRequestMessage()
        {
        }
        
        public JobCrafterDirectoryListRequestMessage(sbyte jobId)
        {
            this.jobId = jobId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(jobId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            jobId = reader.ReadSbyte();
        }
        
    }
    
}