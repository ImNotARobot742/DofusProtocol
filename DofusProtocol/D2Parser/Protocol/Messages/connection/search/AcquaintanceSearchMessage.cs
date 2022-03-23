

// Generated on 03/23/2022 09:50:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AcquaintanceSearchMessage : NetworkMessage
    {
        public const uint Id = 2520;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AccountTagInformation tag;
        
        public AcquaintanceSearchMessage()
        {
        }
        
        public AcquaintanceSearchMessage(Types.AccountTagInformation tag)
        {
            this.tag = tag;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            tag.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            tag = new Types.AccountTagInformation();
            tag.Deserialize(reader);
        }
        
    }
    
}