

// Generated on 06/02/2023 19:00:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PopupWarningCloseRequestMessage : NetworkMessage
    {
        public const uint Id = 8676;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PopupWarningCloseRequestMessage()
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