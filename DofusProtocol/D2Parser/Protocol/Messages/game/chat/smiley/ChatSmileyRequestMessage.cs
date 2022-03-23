

// Generated on 03/23/2022 09:50:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatSmileyRequestMessage : NetworkMessage
    {
        public const uint Id = 943;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint smileyId;
        
        public ChatSmileyRequestMessage()
        {
        }
        
        public ChatSmileyRequestMessage(uint smileyId)
        {
            this.smileyId = smileyId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)smileyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            smileyId = reader.ReadVarUShort();
        }
        
    }
    
}