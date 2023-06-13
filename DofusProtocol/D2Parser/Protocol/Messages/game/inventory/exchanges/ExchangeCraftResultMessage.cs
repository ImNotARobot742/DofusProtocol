

// Generated on 06/13/2023 16:59:51
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeCraftResultMessage : NetworkMessage
    {
        public const uint Id = 8578;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte craftResult;
        
        public ExchangeCraftResultMessage()
        {
        }
        
        public ExchangeCraftResultMessage(sbyte craftResult)
        {
            this.craftResult = craftResult;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(craftResult);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            craftResult = reader.ReadSbyte();
        }
        
    }
    
}