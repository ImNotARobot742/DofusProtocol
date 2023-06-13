

// Generated on 06/13/2023 16:59:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LocalizedChatSmileyMessage : ChatSmileyMessage
    {
        public const uint Id = 5526;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cellId;
        
        public LocalizedChatSmileyMessage()
        {
        }
        
        public LocalizedChatSmileyMessage(double entityId, uint smileyId, int accountId, uint cellId)
         : base(entityId, smileyId, accountId)
        {
            this.cellId = cellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            cellId = reader.ReadVarUShort();
        }
        
    }
    
}