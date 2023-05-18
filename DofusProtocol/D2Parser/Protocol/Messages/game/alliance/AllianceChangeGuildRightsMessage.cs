

// Generated on 05/18/2023 16:28:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceChangeGuildRightsMessage : NetworkMessage
    {
        public const uint Id = 9229;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint guildId;
        public sbyte rights;
        
        public AllianceChangeGuildRightsMessage()
        {
        }
        
        public AllianceChangeGuildRightsMessage(uint guildId, sbyte rights)
        {
            this.guildId = guildId;
            this.rights = rights;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)guildId);
            writer.WriteSbyte(rights);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            guildId = reader.ReadVarUInt();
            rights = reader.ReadSbyte();
        }
        
    }
    
}