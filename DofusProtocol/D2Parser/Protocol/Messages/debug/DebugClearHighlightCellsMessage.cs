

// Generated on 02/01/2023 12:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DebugClearHighlightCellsMessage : NetworkMessage
    {
        public const uint Id = 3285;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public DebugClearHighlightCellsMessage()
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