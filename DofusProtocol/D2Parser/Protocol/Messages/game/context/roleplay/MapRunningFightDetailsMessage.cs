

// Generated on 06/02/2023 19:00:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MapRunningFightDetailsMessage : NetworkMessage
    {
        public const uint Id = 3502;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        public Types.GameFightFighterLightInformations[] attackers;
        public Types.GameFightFighterLightInformations[] defenders;
        
        public MapRunningFightDetailsMessage()
        {
        }
        
        public MapRunningFightDetailsMessage(uint fightId, Types.GameFightFighterLightInformations[] attackers, Types.GameFightFighterLightInformations[] defenders)
        {
            this.fightId = fightId;
            this.attackers = attackers;
            this.defenders = defenders;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)fightId);
            writer.WriteShort((short)attackers.Length);
            foreach (var entry in attackers)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)defenders.Length);
            foreach (var entry in defenders)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            attackers = new Types.GameFightFighterLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 attackers[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterLightInformations>(reader.ReadUShort());
                 attackers[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            defenders = new Types.GameFightFighterLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 defenders[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterLightInformations>(reader.ReadUShort());
                 defenders[i].Deserialize(reader);
            }
        }
        
    }
    
}