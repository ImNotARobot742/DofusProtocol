

// Generated on 06/13/2023 16:59:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightPlacementSwapPositionsCancelMessage : NetworkMessage
    {
        public const uint Id = 7982;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int requestId;
        
        public GameFightPlacementSwapPositionsCancelMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsCancelMessage(int requestId)
        {
            this.requestId = requestId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(requestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            requestId = reader.ReadInt();
        }
        
    }
    
}