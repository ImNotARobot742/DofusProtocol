

// Generated on 03/23/2022 09:50:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class WatchQuestListMessage : QuestListMessage
    {
        public const uint Id = 3233;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double playerId;
        
        public WatchQuestListMessage()
        {
        }
        
        public WatchQuestListMessage(uint[] finishedQuestsIds, uint[] finishedQuestsCounts, Types.QuestActiveInformations[] activeQuests, uint[] reinitDoneQuestsIds, double playerId)
         : base(finishedQuestsIds, finishedQuestsCounts, activeQuests, reinitDoneQuestsIds)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarULong();
        }
        
    }
    
}