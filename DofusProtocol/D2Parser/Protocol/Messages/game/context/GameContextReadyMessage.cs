

// Generated on 02/01/2023 12:53:10
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
        public const uint Id = 8859;
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