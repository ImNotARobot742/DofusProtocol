

// Generated on 06/13/2023 16:59:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightPlacementSwapPositionsCancelledMessage : NetworkMessage
    {
        public const uint Id = 3509;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int requestId;
        public double cancellerId;
        
        public GameFightPlacementSwapPositionsCancelledMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsCancelledMessage(int requestId, double cancellerId)
        {
            this.requestId = requestId;
            this.cancellerId = cancellerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(requestId);
            writer.WriteDouble(cancellerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            requestId = reader.ReadInt();
            cancellerId = reader.ReadDouble();
        }
        
    }
    
}