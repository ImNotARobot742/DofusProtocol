

// Generated on 02/01/2023 12:53:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatServerCopyMessage : ChatAbstractServerMessage
    {
        public const uint Id = 5300;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double receiverId;
        public string receiverName;
        
        public ChatServerCopyMessage()
        {
        }
        
        public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, double receiverId, string receiverName)
         : base(channel, content, timestamp, fingerprint)
        {
            this.receiverId = receiverId;
            this.receiverName = receiverName;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(receiverId);
            writer.WriteUTF(receiverName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            receiverId = reader.ReadVarULong();
            receiverName = reader.ReadUTF();
        }
        
    }
    
}