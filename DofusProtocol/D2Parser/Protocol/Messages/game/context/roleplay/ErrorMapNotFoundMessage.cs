

// Generated on 02/01/2023 12:53:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ErrorMapNotFoundMessage : NetworkMessage
    {
        public const uint Id = 6809;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mapId;
        
        public ErrorMapNotFoundMessage()
        {
        }
        
        public ErrorMapNotFoundMessage(double mapId)
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