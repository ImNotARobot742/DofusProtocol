

// Generated on 06/02/2023 19:00:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
    {
        public const uint Id = 6838;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double quantity;
        
        public ExchangeKamaModifiedMessage()
        {
        }
        
        public ExchangeKamaModifiedMessage(bool remote, double quantity)
         : base(remote)
        {
            this.quantity = quantity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            quantity = reader.ReadVarULong();
        }
        
    }
    
}