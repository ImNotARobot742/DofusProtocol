

// Generated on 03/23/2022 09:50:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TreasureHuntRequestAnswerMessage : NetworkMessage
    {
        public const uint Id = 6318;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte questType;
        public sbyte result;
        
        public TreasureHuntRequestAnswerMessage()
        {
        }
        
        public TreasureHuntRequestAnswerMessage(sbyte questType, sbyte result)
        {
            this.questType = questType;
            this.result = result;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(questType);
            writer.WriteSbyte(result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questType = reader.ReadSbyte();
            result = reader.ReadSbyte();
        }
        
    }
    
}