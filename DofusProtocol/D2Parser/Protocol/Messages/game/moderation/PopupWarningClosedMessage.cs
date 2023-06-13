

// Generated on 06/13/2023 16:59:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PopupWarningClosedMessage : NetworkMessage
    {
        public const uint Id = 4908;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PopupWarningClosedMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}