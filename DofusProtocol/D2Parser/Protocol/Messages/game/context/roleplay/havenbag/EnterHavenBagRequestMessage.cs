

// Generated on 06/02/2023 19:00:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class EnterHavenBagRequestMessage : NetworkMessage
    {
        public const uint Id = 3961;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double havenBagOwner;
        
        public EnterHavenBagRequestMessage()
        {
        }
        
        public EnterHavenBagRequestMessage(double havenBagOwner)
        {
            this.havenBagOwner = havenBagOwner;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(havenBagOwner);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            havenBagOwner = reader.ReadVarULong();
        }
        
    }
    
}