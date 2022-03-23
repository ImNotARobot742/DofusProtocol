

// Generated on 03/23/2022 09:50:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismFightAttackerAddMessage : NetworkMessage
    {
        public const uint Id = 5938;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        public uint fightId;
        public Types.CharacterMinimalPlusLookInformations attacker;
        
        public PrismFightAttackerAddMessage()
        {
        }
        
        public PrismFightAttackerAddMessage(uint subAreaId, uint fightId, Types.CharacterMinimalPlusLookInformations attacker)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.attacker = attacker;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)subAreaId);
            writer.WriteVarShort((short)fightId);
            writer.WriteShort(attacker.TypeId);
            attacker.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUShort();
            fightId = reader.ReadVarUShort();
            attacker = ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadUShort());
            attacker.Deserialize(reader);
        }
        
    }
    
}