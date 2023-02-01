

// Generated on 02/01/2023 12:53:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class OrnamentLostMessage : NetworkMessage
    {
        public const uint Id = 1592;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short ornamentId;
        
        public OrnamentLostMessage()
        {
        }
        
        public OrnamentLostMessage(short ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(ornamentId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            ornamentId = reader.ReadShort();
        }
        
    }
    
}