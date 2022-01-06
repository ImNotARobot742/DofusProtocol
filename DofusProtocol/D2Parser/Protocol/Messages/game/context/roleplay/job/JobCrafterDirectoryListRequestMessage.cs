

// Generated on 01/01/2022 14:39:32
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
        public const uint Id = 5786;
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