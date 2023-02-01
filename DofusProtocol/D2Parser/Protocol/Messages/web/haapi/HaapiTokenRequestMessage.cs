

// Generated on 02/01/2023 12:53:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiTokenRequestMessage : NetworkMessage
    {
        public const uint Id = 8233;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public HaapiTokenRequestMessage()
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