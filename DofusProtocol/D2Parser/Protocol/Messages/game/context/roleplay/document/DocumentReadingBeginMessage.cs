

// Generated on 03/23/2022 09:50:22
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
        public const uint Id = 2676;
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