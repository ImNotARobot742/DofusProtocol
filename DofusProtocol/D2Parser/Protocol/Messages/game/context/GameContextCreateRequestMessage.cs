

// Generated on 03/23/2022 09:50:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameContextCreateRequestMessage : NetworkMessage
    {
        public const uint Id = 2168;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GameContextCreateRequestMessage()
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