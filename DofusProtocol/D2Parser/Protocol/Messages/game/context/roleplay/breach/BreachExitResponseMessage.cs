

// Generated on 03/23/2022 09:50:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachExitResponseMessage : NetworkMessage
    {
        public const uint Id = 1265;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool exited;
        
        public BreachExitResponseMessage()
        {
        }
        
        public BreachExitResponseMessage(bool exited)
        {
            this.exited = exited;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(exited);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            exited = reader.ReadBoolean();
        }
        
    }
    
}