

// Generated on 02/01/2023 12:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHouseItemRemoveOkMessage : NetworkMessage
    {
        public const uint Id = 3056;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int sellerId;
        
        public ExchangeBidHouseItemRemoveOkMessage()
        {
        }
        
        public ExchangeBidHouseItemRemoveOkMessage(int sellerId)
        {
            this.sellerId = sellerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(sellerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            sellerId = reader.ReadInt();
        }
        
    }
    
}