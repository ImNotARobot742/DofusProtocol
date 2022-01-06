

// Generated on 01/01/2022 14:39:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ContactLookErrorMessage : NetworkMessage
    {
        public const uint Id = 9873;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint requestId;
        
        public ContactLookErrorMessage()
        {
        }
        
        public ContactLookErrorMessage(uint requestId)
        {
            this.requestId = requestId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)requestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            requestId = reader.ReadVarUInt();
        }
        
    }
    
}