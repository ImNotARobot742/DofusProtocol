

// Generated on 06/13/2023 16:59:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ClientKeyMessage : NetworkMessage
    {
        public const uint Id = 729;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string key;
        
        public ClientKeyMessage()
        {
        }
        
        public ClientKeyMessage(string key)
        {
            this.key = key;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(key);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            key = reader.ReadUTF();
        }
        
    }
    
}