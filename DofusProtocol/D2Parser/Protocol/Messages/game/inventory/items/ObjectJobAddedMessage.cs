

// Generated on 03/23/2022 09:50:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectJobAddedMessage : NetworkMessage
    {
        public const uint Id = 8091;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte jobId;
        
        public ObjectJobAddedMessage()
        {
        }
        
        public ObjectJobAddedMessage(sbyte jobId)
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