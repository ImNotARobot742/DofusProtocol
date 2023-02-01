

// Generated on 02/01/2023 12:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismUseRequestMessage : NetworkMessage
    {
        public const uint Id = 5796;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte moduleToUse;
        
        public PrismUseRequestMessage()
        {
        }
        
        public PrismUseRequestMessage(sbyte moduleToUse)
        {
            this.moduleToUse = moduleToUse;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(moduleToUse);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            moduleToUse = reader.ReadSbyte();
        }
        
    }
    
}