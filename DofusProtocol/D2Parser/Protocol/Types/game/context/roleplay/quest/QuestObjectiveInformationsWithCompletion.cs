

// Generated on 05/18/2023 15:10:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
    {
        public const short Id = 62;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint curCompletion;
        public uint maxCompletion;
        
        public QuestObjectiveInformationsWithCompletion()
        {
        }
        
        public QuestObjectiveInformationsWithCompletion(uint objectiveId, bool objectiveStatus, string[] dialogParams, uint curCompletion, uint maxCompletion)
         : base(objectiveId, objectiveStatus, dialogParams)
        {
            this.curCompletion = curCompletion;
            this.maxCompletion = maxCompletion;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)curCompletion);
            writer.WriteVarShort((short)maxCompletion);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            curCompletion = reader.ReadVarUShort();
            maxCompletion = reader.ReadVarUShort();
        }
        
    }
    
}