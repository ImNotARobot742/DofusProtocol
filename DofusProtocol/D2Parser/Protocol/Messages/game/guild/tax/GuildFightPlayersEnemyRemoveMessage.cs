

// Generated on 06/02/2023 19:00:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildFightPlayersEnemyRemoveMessage : NetworkMessage
    {
        public const uint Id = 738;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double fightId;
        public double playerId;
        
        public GuildFightPlayersEnemyRemoveMessage()
        {
        }
        
        public GuildFightPlayersEnemyRemoveMessage(double fightId, double playerId)
        {
            this.fightId = fightId;
            this.playerId = playerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(fightId);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadDouble();
            playerId = reader.ReadVarULong();
        }
        
    }
    
}