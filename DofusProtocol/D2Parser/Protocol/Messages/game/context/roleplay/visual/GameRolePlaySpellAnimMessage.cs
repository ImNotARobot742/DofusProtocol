

// Generated on 06/02/2023 19:00:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlaySpellAnimMessage : NetworkMessage
    {
        public const uint Id = 9549;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double casterId;
        public uint targetCellId;
        public uint spellId;
        public short spellLevel;
        public short direction;
        
        public GameRolePlaySpellAnimMessage()
        {
        }
        
        public GameRolePlaySpellAnimMessage(double casterId, uint targetCellId, uint spellId, short spellLevel, short direction)
        {
            this.casterId = casterId;
            this.targetCellId = targetCellId;
            this.spellId = spellId;
            this.spellLevel = spellLevel;
            this.direction = direction;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(casterId);
            writer.WriteVarShort((short)targetCellId);
            writer.WriteVarShort((short)spellId);
            writer.WriteShort(spellLevel);
            writer.WriteShort(direction);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            casterId = reader.ReadVarULong();
            targetCellId = reader.ReadVarUShort();
            spellId = reader.ReadVarUShort();
            spellLevel = reader.ReadShort();
            direction = reader.ReadShort();
        }
        
    }
    
}