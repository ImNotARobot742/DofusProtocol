

// Generated on 03/23/2022 09:50:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildApplicationAnswerMessage : NetworkMessage
    {
        public const uint Id = 507;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool accepted;
        public double playerId;
        
        public GuildApplicationAnswerMessage()
        {
        }
        
        public GuildApplicationAnswerMessage(bool accepted, double playerId)
        {
            this.accepted = accepted;
            this.playerId = playerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(accepted);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            accepted = reader.ReadBoolean();
            playerId = reader.ReadVarULong();
        }
        
    }
    
}