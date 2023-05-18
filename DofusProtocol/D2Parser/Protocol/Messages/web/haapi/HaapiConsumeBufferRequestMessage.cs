

// Generated on 05/18/2023 16:29:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiConsumeBufferRequestMessage : NetworkMessage
    {
        public const uint Id = 8650;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public HaapiConsumeBufferRequestMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}