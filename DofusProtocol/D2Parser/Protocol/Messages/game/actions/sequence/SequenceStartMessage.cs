

// Generated on 03/23/2022 09:50:12
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SequenceStartMessage : NetworkMessage
    {
        public const uint Id = 1744;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte sequenceType;
        public double authorId;
        
        public SequenceStartMessage()
        {
        }
        
        public SequenceStartMessage(sbyte sequenceType, double authorId)
        {
            this.sequenceType = sequenceType;
            this.authorId = authorId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(sequenceType);
            writer.WriteDouble(authorId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            sequenceType = reader.ReadSbyte();
            authorId = reader.ReadDouble();
        }
        
    }
    
}