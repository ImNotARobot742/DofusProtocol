

// Generated on 06/13/2023 16:59:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightSpectatePlayerRequestMessage : NetworkMessage
    {
        public const uint Id = 4811;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double playerId;
        
        public GameFightSpectatePlayerRequestMessage()
        {
        }
        
        public GameFightSpectatePlayerRequestMessage(double playerId)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            playerId = reader.ReadVarULong();
        }
        
    }
    
}