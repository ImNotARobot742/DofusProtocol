

// Generated on 05/18/2023 15:10:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiApiKeyMessage : NetworkMessage
    {
        public const uint Id = 586;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string token;
        
        public HaapiApiKeyMessage()
        {
        }
        
        public HaapiApiKeyMessage(string token)
        {
            this.token = token;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(token);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            token = reader.ReadUTF();
        }
        
    }
    
}