

// Generated on 06/02/2023 19:00:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlterationAddedMessage : NetworkMessage
    {
        public const uint Id = 7498;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AlterationInfo alteration;
        
        public AlterationAddedMessage()
        {
        }
        
        public AlterationAddedMessage(Types.AlterationInfo alteration)
        {
            this.alteration = alteration;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            alteration.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            alteration = new Types.AlterationInfo();
            alteration.Deserialize(reader);
        }
        
    }
    
}