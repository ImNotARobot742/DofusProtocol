

// Generated on 02/01/2023 12:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObtainedItemWithBonusMessage : ObtainedItemMessage
    {
        public const uint Id = 9026;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint bonusQuantity;
        
        public ObtainedItemWithBonusMessage()
        {
        }
        
        public ObtainedItemWithBonusMessage(uint genericId, uint baseQuantity, uint bonusQuantity)
         : base(genericId, baseQuantity)
        {
            this.bonusQuantity = bonusQuantity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)bonusQuantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            bonusQuantity = reader.ReadVarUInt();
        }
        
    }
    
}