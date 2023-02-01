

// Generated on 02/01/2023 12:53:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatKolizeumServerMessage : ChatServerMessage
    {
        public const uint Id = 1773;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short originServerId;
        
        public ChatKolizeumServerMessage()
        {
        }
        
        public ChatKolizeumServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, string prefix, int senderAccountId, short originServerId)
         : base(channel, content, timestamp, fingerprint, senderId, senderName, prefix, senderAccountId)
        {
            this.originServerId = originServerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(originServerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            originServerId = reader.ReadShort();
        }
        
    }
    
}