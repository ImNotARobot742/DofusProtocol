

// Generated on 03/23/2022 09:50:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHousePriceMessage : NetworkMessage
    {
        public const uint Id = 361;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint genId;
        
        public ExchangeBidHousePriceMessage()
        {
        }
        
        public ExchangeBidHousePriceMessage(uint genId)
        {
            this.genId = genId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)genId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            genId = reader.ReadVarUShort();
        }
        
    }
    
}