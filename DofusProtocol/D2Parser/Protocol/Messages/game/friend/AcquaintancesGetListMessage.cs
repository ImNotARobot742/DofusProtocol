

// Generated on 01/01/2022 14:39:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AcquaintancesGetListMessage : NetworkMessage
    {
        public const uint Id = 4271;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AcquaintancesGetListMessage()
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