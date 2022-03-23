

// Generated on 03/23/2022 09:50:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QuestObjectiveValidatedMessage : NetworkMessage
    {
        public const uint Id = 5846;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint questId;
        public uint objectiveId;
        
        public QuestObjectiveValidatedMessage()
        {
        }
        
        public QuestObjectiveValidatedMessage(uint questId, uint objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)questId);
            writer.WriteVarShort((short)objectiveId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questId = reader.ReadVarUShort();
            objectiveId = reader.ReadVarUShort();
        }
        
    }
    
}