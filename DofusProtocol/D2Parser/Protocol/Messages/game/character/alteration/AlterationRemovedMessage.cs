

// Generated on 05/18/2023 15:10:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlterationRemovedMessage : NetworkMessage
    {
        public const uint Id = 5869;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AlterationInfo alteration;
        
        public AlterationRemovedMessage()
        {
        }
        
        public AlterationRemovedMessage(Types.AlterationInfo alteration)
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