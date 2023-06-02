

// Generated on 06/02/2023 19:00:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CreateGuildRankRequestMessage : NetworkMessage
    {
        public const uint Id = 6896;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint parentRankId;
        public uint gfxId;
        public string name;
        
        public CreateGuildRankRequestMessage()
        {
        }
        
        public CreateGuildRankRequestMessage(uint parentRankId, uint gfxId, string name)
        {
            this.parentRankId = parentRankId;
            this.gfxId = gfxId;
            this.name = name;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)parentRankId);
            writer.WriteVarInt((int)gfxId);
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            parentRankId = reader.ReadVarUInt();
            gfxId = reader.ReadVarUInt();
            name = reader.ReadUTF();
        }
        
    }
    
}