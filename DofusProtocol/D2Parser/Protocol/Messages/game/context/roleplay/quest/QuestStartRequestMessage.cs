

// Generated on 05/18/2023 15:10:33
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
        public const uint Id = 870;
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