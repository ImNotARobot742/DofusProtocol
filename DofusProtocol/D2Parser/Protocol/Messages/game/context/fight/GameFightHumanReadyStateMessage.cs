

// Generated on 01/01/2022 14:39:22
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
        public const uint Id = 4318;
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