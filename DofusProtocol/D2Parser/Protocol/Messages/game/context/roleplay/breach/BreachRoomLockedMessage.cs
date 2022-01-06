

// Generated on 01/01/2022 14:39:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachRoomLockedMessage : NetworkMessage
    {
        public const uint Id = 7221;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public BreachRoomLockedMessage()
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