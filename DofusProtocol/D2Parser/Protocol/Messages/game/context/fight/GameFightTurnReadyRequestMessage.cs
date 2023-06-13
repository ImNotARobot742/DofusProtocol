

// Generated on 06/13/2023 16:59:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightTurnReadyRequestMessage : NetworkMessage
    {
        public const uint Id = 1326;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double id;
        
        public GameFightTurnReadyRequestMessage()
        {
        }
        
        public GameFightTurnReadyRequestMessage(double id)
        {
            this.id = id;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(id);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            id = reader.ReadDouble();
        }
        
    }
    
}