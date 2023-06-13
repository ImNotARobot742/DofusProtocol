

// Generated on 06/13/2023 16:59:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class EmotePlayRequestMessage : NetworkMessage
    {
        public const uint Id = 9735;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public ushort emoteId;
        
        public EmotePlayRequestMessage()
        {
        }
        
        public EmotePlayRequestMessage(ushort emoteId)
        {
            this.emoteId = emoteId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(emoteId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            emoteId = reader.ReadUShort();
        }
        
    }
    
}