

// Generated on 05/18/2023 16:28:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class WatchQuestStepInfoRequestMessage : QuestStepInfoRequestMessage
    {
        public const uint Id = 9073;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double playerId;
        
        public WatchQuestStepInfoRequestMessage()
        {
        }
        
        public WatchQuestStepInfoRequestMessage(uint questId, double playerId)
         : base(questId)
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