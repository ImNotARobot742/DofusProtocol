

// Generated on 03/23/2022 09:50:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AbstractPartyEventMessage : AbstractPartyMessage
    {
        public const uint Id = 8734;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AbstractPartyEventMessage()
        {
        }
        
        public AbstractPartyEventMessage(uint partyId)
         : base(partyId)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}