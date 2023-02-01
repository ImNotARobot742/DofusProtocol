

// Generated on 02/01/2023 12:53:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameContextKickMessage : NetworkMessage
    {
        public const uint Id = 4389;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        
        public GameContextKickMessage()
        {
        }
        
        public GameContextKickMessage(double targetId)
        {
            this.targetId = targetId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            targetId = reader.ReadDouble();
        }
        
    }
    
}