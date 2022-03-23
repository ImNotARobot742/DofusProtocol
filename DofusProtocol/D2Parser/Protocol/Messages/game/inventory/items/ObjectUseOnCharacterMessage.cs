

// Generated on 03/23/2022 09:50:39
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
        public const uint Id = 4424;
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