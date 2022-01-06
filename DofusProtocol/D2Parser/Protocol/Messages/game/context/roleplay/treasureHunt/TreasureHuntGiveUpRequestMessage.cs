

// Generated on 01/01/2022 14:39:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TreasureHuntGiveUpRequestMessage : NetworkMessage
    {
        public const uint Id = 2962;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte questType;
        
        public TreasureHuntGiveUpRequestMessage()
        {
        }
        
        public TreasureHuntGiveUpRequestMessage(sbyte questType)
        {
            this.questType = questType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(questType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questType = reader.ReadSbyte();
        }
        
    }
    
}