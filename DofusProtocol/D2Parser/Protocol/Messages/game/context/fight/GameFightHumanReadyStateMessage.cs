

// Generated on 05/18/2023 15:10:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightHumanReadyStateMessage : NetworkMessage
    {
        public const uint Id = 4425;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double characterId;
        public bool isReady;
        
        public GameFightHumanReadyStateMessage()
        {
        }
        
        public GameFightHumanReadyStateMessage(double characterId, bool isReady)
        {
            this.characterId = characterId;
            this.isReady = isReady;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(characterId);
            writer.WriteBoolean(isReady);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            characterId = reader.ReadVarULong();
            isReady = reader.ReadBoolean();
        }
        
    }
    
}