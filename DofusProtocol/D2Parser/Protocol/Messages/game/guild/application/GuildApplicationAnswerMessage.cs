

// Generated on 01/01/2022 14:39:42
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
        public const uint Id = 5404;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool accepted;
        public uint playerId;
        
        public GuildApplicationAnswerMessage()
        {
        }
        
        public GuildApplicationAnswerMessage(bool accepted, uint playerId)
        {
            this.accepted = accepted;
            this.playerId = playerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(accepted);
            writer.WriteVarInt((int)playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            accepted = reader.ReadBoolean();
            playerId = reader.ReadVarUInt();
        }
        
    }
    
}