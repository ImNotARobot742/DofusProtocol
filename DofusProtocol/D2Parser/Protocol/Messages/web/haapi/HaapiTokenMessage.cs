

// Generated on 06/02/2023 19:00:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiTokenMessage : NetworkMessage
    {
        public const uint Id = 9720;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string token;
        
        public HaapiTokenMessage()
        {
        }
        
        public HaapiTokenMessage(string token)
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