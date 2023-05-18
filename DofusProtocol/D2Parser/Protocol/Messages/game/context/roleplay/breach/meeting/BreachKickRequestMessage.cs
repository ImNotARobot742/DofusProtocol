

// Generated on 05/18/2023 16:28:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachKickRequestMessage : NetworkMessage
    {
        public const uint Id = 1675;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double target;
        
        public BreachKickRequestMessage()
        {
        }
        
        public BreachKickRequestMessage(double target)
        {
            this.target = target;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(target);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            target = reader.ReadVarULong();
        }
        
    }
    
}