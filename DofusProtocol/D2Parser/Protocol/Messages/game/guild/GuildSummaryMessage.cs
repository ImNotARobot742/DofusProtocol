

// Generated on 05/18/2023 15:10:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildSummaryMessage : PaginationAnswerAbstractMessage
    {
        public const uint Id = 8421;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GuildFactSheetInformations[] guilds;
        
        public GuildSummaryMessage()
        {
        }
        
        public GuildSummaryMessage(double offset, uint count, uint total, Types.GuildFactSheetInformations[] guilds)
         : base(offset, count, total)
        {
            this.guilds = guilds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            guilds = new Types.GuildFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildFactSheetInformations();
                 guilds[i].Deserialize(reader);
            }
        }
        
    }
    
}