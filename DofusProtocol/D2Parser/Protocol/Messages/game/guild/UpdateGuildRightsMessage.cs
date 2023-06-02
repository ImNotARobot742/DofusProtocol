

// Generated on 06/02/2023 19:00:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class UpdateGuildRightsMessage : NetworkMessage
    {
        public const uint Id = 5867;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint rankId;
        public uint[] rights;
        
        public UpdateGuildRightsMessage()
        {
        }
        
        public UpdateGuildRightsMessage(uint rankId, uint[] rights)
        {
            this.rankId = rankId;
            this.rights = rights;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)rankId);
            writer.WriteShort((short)rights.Length);
            foreach (var entry in rights)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            rankId = reader.ReadVarUInt();
            var limit = (ushort)reader.ReadUShort();
            rights = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 rights[i] = reader.ReadVarUInt();
            }
        }
        
    }
    
}