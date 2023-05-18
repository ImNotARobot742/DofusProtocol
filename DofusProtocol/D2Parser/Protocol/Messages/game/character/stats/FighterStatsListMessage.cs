

// Generated on 05/18/2023 16:28:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FighterStatsListMessage : NetworkMessage
    {
        public const uint Id = 478;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.CharacterCharacteristicsInformations stats;
        
        public FighterStatsListMessage()
        {
        }
        
        public FighterStatsListMessage(Types.CharacterCharacteristicsInformations stats)
        {
            this.stats = stats;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            stats.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            stats = new Types.CharacterCharacteristicsInformations();
            stats.Deserialize(reader);
        }
        
    }
    
}