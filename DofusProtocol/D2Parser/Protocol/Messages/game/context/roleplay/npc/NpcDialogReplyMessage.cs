

// Generated on 06/13/2023 16:59:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class NpcDialogReplyMessage : NetworkMessage
    {
        public const uint Id = 1445;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint replyId;
        
        public NpcDialogReplyMessage()
        {
        }
        
        public NpcDialogReplyMessage(uint replyId)
        {
            this.replyId = replyId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)replyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            replyId = reader.ReadVarUInt();
        }
        
    }
    
}