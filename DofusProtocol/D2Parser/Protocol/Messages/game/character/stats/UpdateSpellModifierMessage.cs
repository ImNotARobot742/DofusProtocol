

// Generated on 06/02/2023 19:00:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class UpdateSpellModifierMessage : NetworkMessage
    {
        public const uint Id = 7709;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double actorId;
        public Types.CharacterSpellModification spellModifier;
        
        public UpdateSpellModifierMessage()
        {
        }
        
        public UpdateSpellModifierMessage(double actorId, Types.CharacterSpellModification spellModifier)
        {
            this.actorId = actorId;
            this.spellModifier = spellModifier;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(actorId);
            spellModifier.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            actorId = reader.ReadDouble();
            spellModifier = new Types.CharacterSpellModification();
            spellModifier.Deserialize(reader);
        }
        
    }
    
}