

// Generated on 02/01/2023 12:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class UpdateGuildRankRequestMessage : NetworkMessage
    {
        public const uint Id = 1215;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GuildRankInformation rank;
        
        public UpdateGuildRankRequestMessage()
        {
        }
        
        public UpdateGuildRankRequestMessage(Types.GuildRankInformation rank)
        {
            this.rank = rank;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            rank.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            rank = new Types.GuildRankInformation();
            rank.Deserialize(reader);
        }
        
    }
    
}