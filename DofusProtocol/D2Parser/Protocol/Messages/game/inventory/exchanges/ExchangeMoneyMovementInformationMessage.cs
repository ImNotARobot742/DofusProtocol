

// Generated on 01/01/2022 14:39:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeMoneyMovementInformationMessage : NetworkMessage
    {
        public const uint Id = 6336;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double limit;
        
        public ExchangeMoneyMovementInformationMessage()
        {
        }
        
        public ExchangeMoneyMovementInformationMessage(double limit)
        {
            this.limit = limit;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(limit);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            limit = reader.ReadVarULong();
        }
        
    }
    
}