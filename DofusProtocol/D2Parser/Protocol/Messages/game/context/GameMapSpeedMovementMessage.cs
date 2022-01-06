

// Generated on 01/01/2022 14:39:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameMapSpeedMovementMessage : NetworkMessage
    {
        public const uint Id = 8414;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int speedMultiplier;
        
        public GameMapSpeedMovementMessage()
        {
        }
        
        public GameMapSpeedMovementMessage(int speedMultiplier)
        {
            this.speedMultiplier = speedMultiplier;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(speedMultiplier);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            speedMultiplier = reader.ReadInt();
        }
        
    }
    
}