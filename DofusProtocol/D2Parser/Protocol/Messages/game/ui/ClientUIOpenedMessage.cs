

// Generated on 02/01/2023 12:53:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ClientUIOpenedMessage : NetworkMessage
    {
        public const uint Id = 4363;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte type;
        
        public ClientUIOpenedMessage()
        {
        }
        
        public ClientUIOpenedMessage(sbyte type)
        {
            this.type = type;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            type = reader.ReadSbyte();
        }
        
    }
    
}