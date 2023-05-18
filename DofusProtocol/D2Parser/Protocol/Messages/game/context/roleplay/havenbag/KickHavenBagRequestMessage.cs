

// Generated on 05/18/2023 16:28:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class KickHavenBagRequestMessage : NetworkMessage
    {
        public const uint Id = 2873;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double guestId;
        
        public KickHavenBagRequestMessage()
        {
        }
        
        public KickHavenBagRequestMessage(double guestId)
        {
            this.guestId = guestId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(guestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            guestId = reader.ReadVarULong();
        }
        
    }
    
}