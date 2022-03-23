

// Generated on 03/23/2022 09:51:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class QuestActiveInformations
    {
        public const short Id = 3739;
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