

// Generated on 02/01/2023 12:53:21
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
        public const uint Id = 180;
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