

// Generated on 05/18/2023 16:29:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class QuestObjectiveInformations
    {
        public const short Id = 3404;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint objectiveId;
        public bool objectiveStatus;
        public string[] dialogParams;
        
        public QuestObjectiveInformations()
        {
        }
        
        public QuestObjectiveInformations(uint objectiveId, bool objectiveStatus, string[] dialogParams)
        {
            this.objectiveId = objectiveId;
            this.objectiveStatus = objectiveStatus;
            this.dialogParams = dialogParams;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)objectiveId);
            writer.WriteBoolean(objectiveStatus);
            writer.WriteShort((short)dialogParams.Length);
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            objectiveId = reader.ReadVarUShort();
            objectiveStatus = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 dialogParams[i] = reader.ReadUTF();
            }
        }
        
    }
    
}