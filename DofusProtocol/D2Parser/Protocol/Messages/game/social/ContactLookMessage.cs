

// Generated on 03/23/2022 09:50:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ContactLookMessage : NetworkMessage
    {
        public const uint Id = 2975;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint requestId;
        public string playerName;
        public double playerId;
        public Types.EntityLook look;
        
        public ContactLookMessage()
        {
        }
        
        public ContactLookMessage(uint requestId, string playerName, double playerId, Types.EntityLook look)
        {
            this.requestId = requestId;
            this.playerName = playerName;
            this.playerId = playerId;
            this.look = look;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)requestId);
            writer.WriteUTF(playerName);
            writer.WriteVarLong(playerId);
            look.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            requestId = reader.ReadVarUInt();
            playerName = reader.ReadUTF();
            playerId = reader.ReadVarULong();
            look = new Types.EntityLook();
            look.Deserialize(reader);
        }
        
    }
    
}