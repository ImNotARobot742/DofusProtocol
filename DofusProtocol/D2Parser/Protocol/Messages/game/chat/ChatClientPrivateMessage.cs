

// Generated on 06/13/2023 16:59:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatClientPrivateMessage : ChatAbstractClientMessage
    {
        public const uint Id = 6736;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AbstractPlayerSearchInformation receiver;
        
        public ChatClientPrivateMessage()
        {
        }
        
        public ChatClientPrivateMessage(string content, Types.AbstractPlayerSearchInformation receiver)
         : base(content)
        {
            this.receiver = receiver;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(receiver.TypeId);
            receiver.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            receiver = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            receiver.Deserialize(reader);
        }
        
    }
    
}