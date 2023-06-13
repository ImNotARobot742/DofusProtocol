

// Generated on 06/13/2023 16:59:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QuestListMessage : NetworkMessage
    {
        public const uint Id = 9399;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] finishedQuestsIds;
        public uint[] finishedQuestsCounts;
        public Types.QuestActiveInformations[] activeQuests;
        public uint[] reinitDoneQuestsIds;
        
        public QuestListMessage()
        {
        }
        
        public QuestListMessage(uint[] finishedQuestsIds, uint[] finishedQuestsCounts, Types.QuestActiveInformations[] activeQuests, uint[] reinitDoneQuestsIds)
        {
            this.finishedQuestsIds = finishedQuestsIds;
            this.finishedQuestsCounts = finishedQuestsCounts;
            this.activeQuests = activeQuests;
            this.reinitDoneQuestsIds = reinitDoneQuestsIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)finishedQuestsIds.Length);
            foreach (var entry in finishedQuestsIds)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)finishedQuestsCounts.Length);
            foreach (var entry in finishedQuestsCounts)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)activeQuests.Length);
            foreach (var entry in activeQuests)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)reinitDoneQuestsIds.Length);
            foreach (var entry in reinitDoneQuestsIds)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            finishedQuestsIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedQuestsIds[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            finishedQuestsCounts = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedQuestsCounts[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            activeQuests = new Types.QuestActiveInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 activeQuests[i] = ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadUShort());
                 activeQuests[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            reinitDoneQuestsIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 reinitDoneQuestsIds[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}