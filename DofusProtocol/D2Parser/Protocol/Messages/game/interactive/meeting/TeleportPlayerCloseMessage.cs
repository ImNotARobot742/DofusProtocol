

// Generated on 06/02/2023 19:00:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TeleportPlayerCloseMessage : NetworkMessage
    {
        public const uint Id = 2332;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mapId;
        public double requesterId;
        
        public TeleportPlayerCloseMessage()
        {
        }
        
        public TeleportPlayerCloseMessage(double mapId, double requesterId)
        {
            this.mapId = mapId;
            this.requesterId = requesterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(mapId);
            writer.WriteVarLong(requesterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mapId = reader.ReadDouble();
            requesterId = reader.ReadVarULong();
        }
        
    }
    
}