

// Generated on 05/18/2023 16:28:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CloseHavenBagFurnitureSequenceRequestMessage : NetworkMessage
    {
        public const uint Id = 6620;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public CloseHavenBagFurnitureSequenceRequestMessage()
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