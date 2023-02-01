

// Generated on 02/01/2023 12:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeReadyMessage : NetworkMessage
    {
        public const uint Id = 8150;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool ready;
        public uint step;
        
        public ExchangeReadyMessage()
        {
        }
        
        public ExchangeReadyMessage(bool ready, uint step)
        {
            this.ready = ready;
            this.step = step;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(ready);
            writer.WriteVarShort((short)step);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            ready = reader.ReadBoolean();
            step = reader.ReadVarUShort();
        }
        
    }
    
}