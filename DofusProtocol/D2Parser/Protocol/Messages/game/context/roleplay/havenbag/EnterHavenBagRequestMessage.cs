

// Generated on 01/01/2022 14:39:30
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
        public const uint Id = 8214;
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