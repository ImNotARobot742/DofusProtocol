

// Generated on 02/01/2023 12:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatAdminServerMessage : ChatServerMessage
    {
        public const uint Id = 6906;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ChatAdminServerMessage()
        {
        }
        
        public ChatAdminServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, string prefix, int senderAccountId)
         : base(channel, content, timestamp, fingerprint, senderId, senderName, prefix, senderAccountId)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}