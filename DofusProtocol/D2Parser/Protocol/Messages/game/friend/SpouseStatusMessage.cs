

// Generated on 02/01/2023 12:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SpouseStatusMessage : NetworkMessage
    {
        public const uint Id = 2627;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool hasSpouse;
        
        public SpouseStatusMessage()
        {
        }
        
        public SpouseStatusMessage(bool hasSpouse)
        {
            this.hasSpouse = hasSpouse;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(hasSpouse);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            hasSpouse = reader.ReadBoolean();
        }
        
    }
    
}