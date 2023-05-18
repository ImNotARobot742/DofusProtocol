

// Generated on 05/18/2023 15:10:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class UnfollowQuestObjectiveRequestMessage : NetworkMessage
    {
        public const uint Id = 9920;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint questId;
        public short objectiveId;
        
        public UnfollowQuestObjectiveRequestMessage()
        {
        }
        
        public UnfollowQuestObjectiveRequestMessage(uint questId, short objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)questId);
            writer.WriteShort(objectiveId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questId = reader.ReadVarUShort();
            objectiveId = reader.ReadShort();
        }
        
    }
    
}