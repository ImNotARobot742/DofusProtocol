

// Generated on 06/13/2023 16:59:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class RefreshCharacterStatsMessage : NetworkMessage
    {
        public const uint Id = 3387;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double fighterId;
        public Types.GameFightCharacteristics stats;
        
        public RefreshCharacterStatsMessage()
        {
        }
        
        public RefreshCharacterStatsMessage(double fighterId, Types.GameFightCharacteristics stats)
        {
            this.fighterId = fighterId;
            this.stats = stats;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(fighterId);
            stats.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fighterId = reader.ReadDouble();
            stats = new Types.GameFightCharacteristics();
            stats.Deserialize(reader);
        }
        
    }
    
}