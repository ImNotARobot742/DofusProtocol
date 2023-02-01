

// Generated on 02/01/2023 12:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class WrapperObjectAssociatedMessage : SymbioticObjectAssociatedMessage
    {
        public const uint Id = 6952;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public WrapperObjectAssociatedMessage()
        {
        }
        
        public WrapperObjectAssociatedMessage(uint hostUID)
         : base(hostUID)
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