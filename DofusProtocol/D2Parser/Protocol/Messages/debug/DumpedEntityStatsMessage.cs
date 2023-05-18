

// Generated on 05/18/2023 16:28:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DumpedEntityStatsMessage : NetworkMessage
    {
        public const uint Id = 7332;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double actorId;
        public Types.CharacterCharacteristics stats;
        
        public DumpedEntityStatsMessage()
        {
        }
        
        public DumpedEntityStatsMessage(double actorId, Types.CharacterCharacteristics stats)
        {
            this.actorId = actorId;
            this.stats = stats;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(actorId);
            stats.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            actorId = reader.ReadDouble();
            stats = new Types.CharacterCharacteristics();
            stats.Deserialize(reader);
        }
        
    }
    
}