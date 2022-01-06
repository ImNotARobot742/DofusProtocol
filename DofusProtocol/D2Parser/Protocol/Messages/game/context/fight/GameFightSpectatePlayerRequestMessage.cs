

// Generated on 01/01/2022 14:39:23
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
        public const uint Id = 9098;
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