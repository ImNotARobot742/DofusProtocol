

// Generated on 02/01/2023 12:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class QuestActiveDetailedInformations : QuestActiveInformations
    {
        public const short Id = 3883;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint stepId;
        public Types.QuestObjectiveInformations[] objectives;
        
        public QuestActiveDetailedInformations()
        {
        }
        
        public QuestActiveDetailedInformations(uint questId, uint stepId, Types.QuestObjectiveInformations[] objectives)
         : base(questId)
        {
            this.stepId = stepId;
            this.objectives = objectives;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)stepId);
            writer.WriteShort((short)objectives.Length);
            foreach (var entry in objectives)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            stepId = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            objectives = new Types.QuestObjectiveInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectives[i] = ProtocolTypeManager.GetInstance<Types.QuestObjectiveInformations>(reader.ReadUShort());
                 objectives[i].Deserialize(reader);
            }
        }
        
    }
    
}