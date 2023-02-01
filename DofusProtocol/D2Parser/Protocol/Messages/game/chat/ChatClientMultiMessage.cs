

// Generated on 02/01/2023 12:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatClientMultiMessage : ChatAbstractClientMessage
    {
        public const uint Id = 9499;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte channel;
        
        public ChatClientMultiMessage()
        {
        }
        
        public ChatClientMultiMessage(string content, sbyte channel)
         : base(content)
        {
            this.channel = channel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(channel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            channel = reader.ReadSbyte();
        }
        
    }
    
}