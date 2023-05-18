

// Generated on 05/18/2023 15:10:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiValidationRequestMessage : NetworkMessage
    {
        public const uint Id = 9204;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string transaction;
        
        public HaapiValidationRequestMessage()
        {
        }
        
        public HaapiValidationRequestMessage(string transaction)
        {
            this.transaction = transaction;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(transaction);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            transaction = reader.ReadUTF();
        }
        
    }
    
}