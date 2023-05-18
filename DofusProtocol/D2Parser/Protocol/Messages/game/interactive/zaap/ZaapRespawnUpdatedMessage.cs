

// Generated on 05/18/2023 16:29:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ZaapRespawnUpdatedMessage : NetworkMessage
    {
        public const uint Id = 3984;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mapId;
        
        public ZaapRespawnUpdatedMessage()
        {
        }
        
        public ZaapRespawnUpdatedMessage(double mapId)
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