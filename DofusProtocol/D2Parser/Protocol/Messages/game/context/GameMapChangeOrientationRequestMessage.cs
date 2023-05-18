

// Generated on 05/18/2023 15:10:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameMapChangeOrientationRequestMessage : NetworkMessage
    {
        public const uint Id = 4063;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte direction;
        
        public GameMapChangeOrientationRequestMessage()
        {
        }
        
        public GameMapChangeOrientationRequestMessage(sbyte direction)
        {
            this.direction = direction;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(direction);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            direction = reader.ReadSbyte();
        }
        
    }
    
}