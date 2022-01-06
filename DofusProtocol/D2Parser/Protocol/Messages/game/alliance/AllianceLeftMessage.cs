

// Generated on 01/01/2022 14:39:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceLeftMessage : NetworkMessage
    {
        public const uint Id = 1278;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AllianceLeftMessage()
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