

// Generated on 05/18/2023 16:28:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QuestStepStartedMessage : NetworkMessage
    {
        public const uint Id = 6082;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint questId;
        public uint stepId;
        
        public QuestStepStartedMessage()
        {
        }
        
        public QuestStepStartedMessage(uint questId, uint stepId)
        {
            this.questId = questId;
            this.stepId = stepId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)questId);
            writer.WriteVarShort((short)stepId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questId = reader.ReadVarUShort();
            stepId = reader.ReadVarUShort();
        }
        
    }
    
}