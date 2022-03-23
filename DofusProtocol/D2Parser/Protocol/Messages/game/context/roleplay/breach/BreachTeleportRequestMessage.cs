

// Generated on 03/23/2022 09:50:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachTeleportRequestMessage : NetworkMessage
    {
        public const uint Id = 9227;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public BreachTeleportRequestMessage()
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