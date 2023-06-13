

// Generated on 06/13/2023 16:59:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DocumentReadingBeginMessage : NetworkMessage
    {
        public const uint Id = 2916;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint documentId;
        
        public DocumentReadingBeginMessage()
        {
        }
        
        public DocumentReadingBeginMessage(uint documentId)
        {
            this.documentId = documentId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)documentId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            documentId = reader.ReadVarUShort();
        }
        
    }
    
}