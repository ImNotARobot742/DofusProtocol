

// Generated on 06/02/2023 19:01:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class QuestActiveInformations
    {
        public const short Id = 1923;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint questId;
        
        public QuestActiveInformations()
        {
        }
        
        public QuestActiveInformations(uint questId)
        {
            this.questId = questId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)questId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            questId = reader.ReadVarUShort();
        }
        
    }
    
}