

// Generated on 03/23/2022 09:50:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightUpdateTeamMessage : NetworkMessage
    {
        public const uint Id = 985;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        public Types.FightTeamInformations team;
        
        public GameFightUpdateTeamMessage()
        {
        }
        
        public GameFightUpdateTeamMessage(uint fightId, Types.FightTeamInformations team)
        {
            this.fightId = fightId;
            this.team = team;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)fightId);
            team.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUShort();
            team = new Types.FightTeamInformations();
            team.Deserialize(reader);
        }
        
    }
    
}