

// Generated on 03/23/2022 09:50:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismInfoInValidMessage : NetworkMessage
    {
        public const uint Id = 8239;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public PrismInfoInValidMessage()
        {
        }
        
        public PrismInfoInValidMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            reason = reader.ReadSbyte();
        }
        
    }
    
}