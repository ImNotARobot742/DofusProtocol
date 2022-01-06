

// Generated on 01/01/2022 14:39:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QuestStartRequestMessage : NetworkMessage
    {
        public const uint Id = 6071;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint questId;
        
        public QuestStartRequestMessage()
        {
        }
        
        public QuestStartRequestMessage(uint questId)
        {
            this.questId = questId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)questId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questId = reader.ReadVarUShort();
        }
        
    }
    
}