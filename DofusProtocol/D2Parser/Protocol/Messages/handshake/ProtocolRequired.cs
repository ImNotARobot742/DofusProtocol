

// Generated on 06/13/2023 16:59:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ProtocolRequired : NetworkMessage
    {
        public const uint Id = 8889;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string version;
        
        public ProtocolRequired()
        {
        }
        
        public ProtocolRequired(string version)
        {
            this.version = version;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(version);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            version = reader.ReadUTF();
        }
        
    }
    
}