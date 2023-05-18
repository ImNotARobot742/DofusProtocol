

// Generated on 05/18/2023 16:28:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CurrentMapMessage : NetworkMessage
    {
        public const uint Id = 5809;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mapId;
        
        public CurrentMapMessage()
        {
        }
        
        public CurrentMapMessage(double mapId)
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