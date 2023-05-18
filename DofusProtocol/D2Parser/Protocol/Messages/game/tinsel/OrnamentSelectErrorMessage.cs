

// Generated on 05/18/2023 16:29:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class OrnamentSelectErrorMessage : NetworkMessage
    {
        public const uint Id = 3874;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public OrnamentSelectErrorMessage()
        {
        }
        
        public OrnamentSelectErrorMessage(sbyte reason)
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