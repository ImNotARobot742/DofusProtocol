

// Generated on 06/02/2023 19:00:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectAveragePricesErrorMessage : NetworkMessage
    {
        public const uint Id = 6171;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ObjectAveragePricesErrorMessage()
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