

// Generated on 06/13/2023 16:59:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachBudgetMessage : NetworkMessage
    {
        public const uint Id = 2365;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint bugdet;
        
        public BreachBudgetMessage()
        {
        }
        
        public BreachBudgetMessage(uint bugdet)
        {
            this.bugdet = bugdet;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)bugdet);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            bugdet = reader.ReadVarUInt();
        }
        
    }
    
}