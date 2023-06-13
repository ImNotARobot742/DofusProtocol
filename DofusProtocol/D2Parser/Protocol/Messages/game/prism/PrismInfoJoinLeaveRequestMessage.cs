

// Generated on 06/13/2023 16:59:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismInfoJoinLeaveRequestMessage : NetworkMessage
    {
        public const uint Id = 2347;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool join;
        
        public PrismInfoJoinLeaveRequestMessage()
        {
        }
        
        public PrismInfoJoinLeaveRequestMessage(bool join)
        {
            this.join = join;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(join);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            join = reader.ReadBoolean();
        }
        
    }
    
}