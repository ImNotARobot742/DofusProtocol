

// Generated on 01/01/2022 14:39:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightPauseMessage : NetworkMessage
    {
        public const uint Id = 8818;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool isPaused;
        
        public GameFightPauseMessage()
        {
        }
        
        public GameFightPauseMessage(bool isPaused)
        {
            this.isPaused = isPaused;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(isPaused);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            isPaused = reader.ReadBoolean();
        }
        
    }
    
}