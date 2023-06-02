

// Generated on 06/02/2023 19:00:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MimicryObjectPreviewMessage : NetworkMessage
    {
        public const uint Id = 1214;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItem result;
        
        public MimicryObjectPreviewMessage()
        {
        }
        
        public MimicryObjectPreviewMessage(Types.ObjectItem result)
        {
            this.result = result;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            result.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            result = new Types.ObjectItem();
            result.Deserialize(reader);
        }
        
    }
    
}