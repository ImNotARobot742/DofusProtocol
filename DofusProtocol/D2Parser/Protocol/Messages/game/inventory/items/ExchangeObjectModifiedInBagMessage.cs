

// Generated on 05/18/2023 15:10:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeObjectModifiedInBagMessage : ExchangeObjectMessage
    {
        public const uint Id = 8365;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItem @object;
        
        public ExchangeObjectModifiedInBagMessage()
        {
        }
        
        public ExchangeObjectModifiedInBagMessage(bool remote, Types.ObjectItem @object)
         : base(remote)
        {
            this.@object = @object;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            @object.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            @object = new Types.ObjectItem();
            @object.Deserialize(reader);
        }
        
    }
    
}