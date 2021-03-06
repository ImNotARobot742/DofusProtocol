

// Generated on 03/23/2022 09:50:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AcquaintanceAddedMessage : NetworkMessage
    {
        public const uint Id = 2313;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AcquaintanceInformation acquaintanceAdded;
        
        public AcquaintanceAddedMessage()
        {
        }
        
        public AcquaintanceAddedMessage(Types.AcquaintanceInformation acquaintanceAdded)
        {
            this.acquaintanceAdded = acquaintanceAdded;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(acquaintanceAdded.TypeId);
            acquaintanceAdded.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            acquaintanceAdded = ProtocolTypeManager.GetInstance<Types.AcquaintanceInformation>(reader.ReadUShort());
            acquaintanceAdded.Deserialize(reader);
        }
        
    }
    
}