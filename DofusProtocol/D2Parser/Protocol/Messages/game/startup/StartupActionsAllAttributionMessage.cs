

// Generated on 05/18/2023 16:29:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StartupActionsAllAttributionMessage : NetworkMessage
    {
        public const uint Id = 2000;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double characterId;
        
        public StartupActionsAllAttributionMessage()
        {
        }
        
        public StartupActionsAllAttributionMessage(double characterId)
        {
            this.characterId = characterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(characterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            characterId = reader.ReadVarULong();
        }
        
    }
    
}