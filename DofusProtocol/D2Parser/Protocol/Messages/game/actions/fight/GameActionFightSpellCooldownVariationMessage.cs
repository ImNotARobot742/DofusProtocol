

// Generated on 02/01/2023 12:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
    {
        public const uint Id = 1571;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public uint spellId;
        public int value;
        
        public GameActionFightSpellCooldownVariationMessage()
        {
        }
        
        public GameActionFightSpellCooldownVariationMessage(uint actionId, double sourceId, double targetId, uint spellId, int value)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.spellId = spellId;
            this.value = value;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarShort((short)spellId);
            writer.WriteVarShort((short)value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            spellId = reader.ReadVarUShort();
            value = reader.ReadVarShort();
        }
        
    }
    
}