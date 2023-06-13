

// Generated on 06/13/2023 16:59:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BasicPongMessage : NetworkMessage
    {
        public const uint Id = 8750;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool quiet;
        
        public BasicPongMessage()
        {
        }
        
        public BasicPongMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(quiet);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            quiet = reader.ReadBoolean();
        }
        
    }
    
}