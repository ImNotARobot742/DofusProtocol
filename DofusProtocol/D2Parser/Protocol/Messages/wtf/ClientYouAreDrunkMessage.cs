

// Generated on 03/23/2022 09:50:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ClientYouAreDrunkMessage : DebugInClientMessage
    {
        public const uint Id = 367;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ClientYouAreDrunkMessage()
        {
        }
        
        public ClientYouAreDrunkMessage(sbyte level, string message)
         : base(level, message)
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