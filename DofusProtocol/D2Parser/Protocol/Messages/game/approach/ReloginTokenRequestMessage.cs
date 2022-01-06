

// Generated on 01/01/2022 14:39:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ReloginTokenRequestMessage : NetworkMessage
    {
        public const uint Id = 2403;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ReloginTokenRequestMessage()
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