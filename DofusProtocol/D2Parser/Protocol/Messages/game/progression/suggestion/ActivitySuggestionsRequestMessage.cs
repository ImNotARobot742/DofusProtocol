

// Generated on 06/02/2023 19:00:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ActivitySuggestionsRequestMessage : NetworkMessage
    {
        public const uint Id = 7975;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint minLevel;
        public uint maxLevel;
        public uint areaId;
        public uint activityCategoryId;
        public ushort nbCards;
        
        public ActivitySuggestionsRequestMessage()
        {
        }
        
        public ActivitySuggestionsRequestMessage(uint minLevel, uint maxLevel, uint areaId, uint activityCategoryId, ushort nbCards)
        {
            this.minLevel = minLevel;
            this.maxLevel = maxLevel;
            this.areaId = areaId;
            this.activityCategoryId = activityCategoryId;
            this.nbCards = nbCards;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)minLevel);
            writer.WriteVarShort((short)maxLevel);
            writer.WriteVarShort((short)areaId);
            writer.WriteVarShort((short)activityCategoryId);
            writer.WriteUShort(nbCards);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            minLevel = reader.ReadVarUShort();
            maxLevel = reader.ReadVarUShort();
            areaId = reader.ReadVarUShort();
            activityCategoryId = reader.ReadVarUShort();
            nbCards = reader.ReadUShort();
        }
        
    }
    
}