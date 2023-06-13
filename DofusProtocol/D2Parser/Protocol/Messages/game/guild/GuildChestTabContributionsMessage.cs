

// Generated on 06/13/2023 16:59:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildChestTabContributionsMessage : NetworkMessage
    {
        public const uint Id = 5384;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.Contribution[] contributions;
        
        public GuildChestTabContributionsMessage()
        {
        }
        
        public GuildChestTabContributionsMessage(Types.Contribution[] contributions)
        {
            this.contributions = contributions;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)contributions.Length);
            foreach (var entry in contributions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            contributions = new Types.Contribution[limit];
            for (int i = 0; i < limit; i++)
            {
                 contributions[i] = new Types.Contribution();
                 contributions[i].Deserialize(reader);
            }
        }
        
    }
    
}