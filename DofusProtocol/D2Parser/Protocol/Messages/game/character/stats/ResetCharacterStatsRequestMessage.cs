

// Generated on 01/01/2022 14:39:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ResetCharacterStatsRequestMessage : NetworkMessage
    {
        public const uint Id = 9708;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ResetCharacterStatsRequestMessage()
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