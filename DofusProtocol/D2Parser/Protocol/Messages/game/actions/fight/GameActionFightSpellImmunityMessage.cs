

// Generated on 05/18/2023 15:10:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightSpellImmunityMessage : AbstractGameActionMessage
    {
        public const uint Id = 2064;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public uint spellId;
        
        public GameActionFightSpellImmunityMessage()
        {
        }
        
        public GameActionFightSpellImmunityMessage(uint actionId, double sourceId, double targetId, uint spellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.spellId = spellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarShort((short)spellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            spellId = reader.ReadVarUShort();
        }
        
    }
    
}