

// Generated on 03/23/2022 09:50:08
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
        public const uint Id = 5303;
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