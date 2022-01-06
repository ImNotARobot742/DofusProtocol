

// Generated on 01/01/2022 14:39:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MimicryObjectAssociatedMessage : SymbioticObjectAssociatedMessage
    {
        public const uint Id = 8169;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public MimicryObjectAssociatedMessage()
        {
        }
        
        public MimicryObjectAssociatedMessage(uint hostUID)
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