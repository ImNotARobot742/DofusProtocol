

// Generated on 06/13/2023 16:59:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
    {
        public const uint Id = 7451;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint spellId;
        public short spellLevel;
        public short[] portalsIds;
        
        public GameActionFightSpellCastMessage()
        {
        }
        
        public GameActionFightSpellCastMessage(uint actionId, double sourceId, bool silentCast, bool verboseCast, double targetId, short destinationCellId, sbyte critical, uint spellId, short spellLevel, short[] portalsIds)
         : base(actionId, sourceId, silentCast, verboseCast, targetId, destinationCellId, critical)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
            this.portalsIds = portalsIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)spellId);
            writer.WriteShort(spellLevel);
            writer.WriteShort((short)portalsIds.Length);
            foreach (var entry in portalsIds)
            {
                 writer.WriteShort(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            spellId = reader.ReadVarUShort();
            spellLevel = reader.ReadShort();
            var limit = (ushort)reader.ReadUShort();
            portalsIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 portalsIds[i] = reader.ReadShort();
            }
        }
        
    }
    
}