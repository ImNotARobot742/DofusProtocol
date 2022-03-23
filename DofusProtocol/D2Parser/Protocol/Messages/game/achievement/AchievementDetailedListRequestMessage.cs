

// Generated on 03/23/2022 09:50:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AchievementDetailedListRequestMessage : NetworkMessage
    {
        public const uint Id = 6918;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint categoryId;
        
        public AchievementDetailedListRequestMessage()
        {
        }
        
        public AchievementDetailedListRequestMessage(uint categoryId)
        {
            this.categoryId = categoryId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)categoryId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            categoryId = reader.ReadVarUShort();
        }
        
    }
    
}