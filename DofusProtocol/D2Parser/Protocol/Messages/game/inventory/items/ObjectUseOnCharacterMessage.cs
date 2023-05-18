

// Generated on 05/18/2023 15:10:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectUseOnCharacterMessage : ObjectUseMessage
    {
        public const uint Id = 3316;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double characterId;
        
        public ObjectUseOnCharacterMessage()
        {
        }
        
        public ObjectUseOnCharacterMessage(uint objectUID, double characterId)
         : base(objectUID)
        {
            this.characterId = characterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(characterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            characterId = reader.ReadVarULong();
        }
        
    }
    
}