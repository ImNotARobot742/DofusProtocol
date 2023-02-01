

// Generated on 02/01/2023 12:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
    {
        public const uint Id = 8107;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint weaponGenericId;
        
        public GameActionFightCloseCombatMessage()
        {
        }
        
        public GameActionFightCloseCombatMessage(uint actionId, double sourceId, bool silentCast, bool verboseCast, double targetId, short destinationCellId, sbyte critical, uint weaponGenericId)
         : base(actionId, sourceId, silentCast, verboseCast, targetId, destinationCellId, critical)
        {
            this.weaponGenericId = weaponGenericId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)weaponGenericId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            weaponGenericId = reader.ReadVarUShort();
        }
        
    }
    
}