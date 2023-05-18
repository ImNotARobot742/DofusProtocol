

// Generated on 05/18/2023 15:10:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class WatchInventoryContentMessage : InventoryContentMessage
    {
        public const uint Id = 9485;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public WatchInventoryContentMessage()
        {
        }
        
        public WatchInventoryContentMessage(Types.ObjectItem[] objects, double kamas)
         : base(objects, kamas)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}