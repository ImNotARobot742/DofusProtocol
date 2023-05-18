

// Generated on 05/18/2023 16:28:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameContextReadyMessage : NetworkMessage
    {
        public const uint Id = 9978;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mapId;
        
        public GameContextReadyMessage()
        {
        }
        
        public GameContextReadyMessage(double mapId)
        {
            this.mapId = mapId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(mapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mapId = reader.ReadDouble();
        }
        
    }
    
}