

// Generated on 02/01/2023 12:53:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatSmileyMessage : NetworkMessage
    {
        public const uint Id = 1197;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double entityId;
        public uint smileyId;
        public int accountId;
        
        public ChatSmileyMessage()
        {
        }
        
        public ChatSmileyMessage(double entityId, uint smileyId, int accountId)
        {
            this.entityId = entityId;
            this.smileyId = smileyId;
            this.accountId = accountId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(entityId);
            writer.WriteVarShort((short)smileyId);
            writer.WriteInt(accountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            entityId = reader.ReadDouble();
            smileyId = reader.ReadVarUShort();
            accountId = reader.ReadInt();
        }
        
    }
    
}