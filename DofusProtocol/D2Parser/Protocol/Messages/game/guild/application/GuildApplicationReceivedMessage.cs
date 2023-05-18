

// Generated on 05/18/2023 16:29:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildApplicationReceivedMessage : NetworkMessage
    {
        public const uint Id = 4461;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string playerName;
        public double playerId;
        
        public GuildApplicationReceivedMessage()
        {
        }
        
        public GuildApplicationReceivedMessage(string playerName, double playerId)
        {
            this.playerName = playerName;
            this.playerId = playerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(playerName);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            playerName = reader.ReadUTF();
            playerId = reader.ReadVarULong();
        }
        
    }
    
}