

// Generated on 05/18/2023 16:28:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildVersatileInfoListMessage : NetworkMessage
    {
        public const uint Id = 5467;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GuildVersatileInformations[] guilds;
        
        public GuildVersatileInfoListMessage()
        {
        }
        
        public GuildVersatileInfoListMessage(Types.GuildVersatileInformations[] guilds)
        {
            this.guilds = guilds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)guilds.Length);
            foreach (var entry in guilds)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            guilds = new Types.GuildVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = ProtocolTypeManager.GetInstance<Types.GuildVersatileInformations>(reader.ReadUShort());
                 guilds[i].Deserialize(reader);
            }
        }
        
    }
    
}